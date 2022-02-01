using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using IdentityModel.Client;
using Newtonsoft.Json;
using Xero.NetStandard.OAuth2.Models;

namespace XeroSample.TokenGenerator
{
    public partial class MainForm : Form
    {
        // get the client id and generate a secret for your application for the required company:
        // https://developer.xero.com/app/manage
        public string ClientId
        {
            get
            {
                return txtClientId.Text;
            }
        }

        public string ClientSecret
        {
            get
            {
                return txtClientSecret.Text;
            }
        }

        public string CallbackUri
        {
            get
            {
                return txtCallbackURI.Text;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetSuccess(
            string accessToken
            , string identityToken
            , string refreshToken
            , string refreshTokenExpiry
            , string state
            , string message)
        {
            this.Invoke(new Action(() =>
            {
                txtAccessToken.Text = accessToken;
                txtIdentityToken.Text = identityToken;
                txtRefreshToken.Text = refreshToken;
                txtRefreshTokenExpiry.Text = refreshTokenExpiry;
                txtReturnedState.Text = state;
                lblInfo.Text = message;
                lstTenants.DataSource = RetrieveTenants();

                this.BringToFront();
                //MessageBox.Show(
                //          string.Format("Tokens generated successfully.",
                //          System.Environment.NewLine)
                //        , "Generate New Tokens"
                //        , MessageBoxButtons.OK
                //        , MessageBoxIcon.Information);
            }));
        }

        public void SetError(string message)
        {
            this.Invoke(new Action(() =>
            {
                txtAccessToken.Text = string.Empty;
                txtIdentityToken.Text = string.Empty;
                txtRefreshToken.Text = string.Empty;
                txtRefreshTokenExpiry.Text = string.Empty;
                txtReturnedState.Text = string.Empty;
                lblInfo.Text = message;
                this.BringToFront();
            }));
        }

        private List<string> RetrieveTenants()
        {
            this.Cursor = Cursors.WaitCursor;
            this.lblInfo.Text = "Retrieving tenants from Xero. Please wait...";
            try
            {
                List<string> result = new List<string>();
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", txtAccessToken.Text);
                    using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://api.xero.com/connections"))
                    {
                        HttpResponseMessage httpResult = client.SendAsync(requestMessage).Result;
                        if (httpResult.IsSuccessStatusCode)
                        {
                            var tenantResult = httpResult.Content.ReadAsStringAsync().Result;
                            var tenantList = JsonConvert.DeserializeObject<List<Tenant>>(tenantResult);
                            foreach (Tenant tenant in tenantList)
                            {
                                result.Add(
                                    $"{tenant.TenantId}, {tenant.TenantName}, {tenant.TenantType}"
                                );
                            }
                        }
                        else
                        {
                            throw (new Exception(string.Format("Error {0}: {1}", httpResult.StatusCode, httpResult.ReasonPhrase)));
                        }
                    }
                }
                this.Cursor = Cursors.Default;
                this.lblInfo.Text = "Tokens have been succesfully generated.";
                return result;
            }
            catch (Exception ex)
            {
                this.lblInfo.Text = "Error retrieving tenants.";
                this.Cursor = Cursors.Default;
                MessageBox.Show("Unable to retrieve list of tenants: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // examples of scopes
            // see https://developer.xero.com/documentation/guides/oauth2/scopes/ for more details

            lstScopes.Items.Add("offline_access");
            lstScopes.Items.Add("openid");
            lstScopes.Items.Add("profile");
            lstScopes.Items.Add("email");
            lstScopes.Items.Add("accounting.transactions");
            lstScopes.Items.Add("accounting.transactions.read");
            lstScopes.Items.Add("accounting.reports.read");
            lstScopes.Items.Add("accounting.journals.read");
            lstScopes.Items.Add("accounting.settings");
            lstScopes.Items.Add("accounting.settings.read");
            lstScopes.Items.Add("accounting.contacts");
            lstScopes.Items.Add("accounting.contacts.read");
            lstScopes.Items.Add("accounting.attachments");
            lstScopes.Items.Add("accounting.attachments.read");
            //lstScopes.Items.Add("payroll.employees");
            //lstScopes.Items.Add("payroll.employees.read");
            //lstScopes.Items.Add("payroll.payruns");
            //lstScopes.Items.Add("payroll.payruns.read");
            //lstScopes.Items.Add("payroll.payslip");
            //lstScopes.Items.Add("payroll.payslip.read");
            //lstScopes.Items.Add("payroll.timesheets");
            //lstScopes.Items.Add("payroll.timesheets.read");
            //lstScopes.Items.Add("payroll.settings");
            //lstScopes.Items.Add("payroll.settings.read");
            //lstScopes.Items.Add("files");
            //lstScopes.Items.Add("files.read");
            //lstScopes.Items.Add("assets");
            //lstScopes.Items.Add("assets.read");
            //lstScopes.Items.Add("projects");
            //lstScopes.Items.Add("projects.read");
            //lstScopes.Items.Add("workflowmax");
            //lstScopes.Items.Add("workflowmax.read");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientId.Text) ||
                string.IsNullOrWhiteSpace(txtClientSecret.Text) ||
                string.IsNullOrWhiteSpace(txtCallbackURI.Text))
            {
                MessageBox.Show("Please enter all the required fields in the inputs section of the form."
                    , "Invalid Input Data"
                    , MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show(
                      string.Format("By continuing, this application will open your browser where you will have to log into Xero and allow access to generate new tokens.{0}{0}Continue?", Environment.NewLine)
                    , "Generate New Tokens"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question
                    ) != DialogResult.Yes)
            {
                return;
            }
            lblInfo.Text = "Starting browser. Please wait...";

            //var xxx = string.Join(" ", lstScopes.Items.Cast<object>().Select(item => item.ToString()).ToList());
            var xeroAuthorizeUri = new RequestUrl("https://login.xero.com/identity/connect/authorize");
            var url = xeroAuthorizeUri.CreateAuthorizeUrl(
                clientId: txtClientId.Text,
                responseType: "code", //hardcoded authorisation code for now.
                redirectUri: txtCallbackURI.Text,
                state: txtState.Text,
                scope: string.Join(" ", lstScopes.Items.Cast<object>().Select(item => item.ToString()).ToList())
            );

            var xxx = url == $"https://login.xero.com/identity/connect/authorize?client_id=FECD5A3023214CB5B2D8A01BA95E6AB4&response_type=code&scope=offline_access%20openid%20profile%20email&redirect_uri=http%3A%2F%2Flocalhost%3A5000%2Fapi%2Foauth";

            //url = $"https://login.xero.com/identity/connect/authorize?client_id=FECD5A3023214CB5B2D8A01BA95E6AB4&response_type=code&scope=offline_access%20openid%20profile%20email&redirect_uri=http%3A%2F%2Flocalhost%3A5000%2Fapi%2Foauth";
            var process = System.Diagnostics.Process.Start(url);
            lblInfo.Text = "Please use your browser to log into Xero and allow access.";
        }
    }
}

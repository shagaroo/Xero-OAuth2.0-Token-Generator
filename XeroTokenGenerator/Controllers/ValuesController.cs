using System;
using System.Text;
using System.Net.Http;

using Microsoft.AspNetCore.Mvc;
using IdentityModel.Client;

namespace XeroSample.TokenGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // calling http://localhost:5000/api/values in a browser will show value of Program.MainForm.txtClientId.Text in the browser
        //[HttpGet]
        //public ActionResult<string> Get()
        //{
        //    string text = "";
        //    Program.MainForm.Invoke(new Action(() =>
        //    {
        //        text = Program.MainForm.txtClientId.Text;
        //    }));
        //    return text;
        //}

        // calling http://localhost:5000/api/values/abc in a browser will show "abc" in Program.MainForm.txtClientId.Text of the application
        //[HttpGet("{id}")]
        //public ActionResult Get(string id)
        //{
        //    Program.MainForm.Invoke(new Action(() =>
        //    {
        //        Program.MainForm.txtClientId.Text = id;
        //    }));
        //    return Ok();
        //}

        [HttpGet("/api/oauth")]
        public ContentResult Get(string code, string state)
        {
            var result = new ContentResult();
            try
            {
                using (var client = new HttpClient())
                {
                    var byteArray = Encoding.ASCII.GetBytes($"{Program.XeroSampleMainForm.ClientId}:{Program.XeroSampleMainForm.ClientSecret}");
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                    var response = client.RequestAuthorizationCodeTokenAsync(new AuthorizationCodeTokenRequest
                    {
                        Address = "https://identity.xero.com/connect/token",
                        GrantType = "authorization_code",
                        Code = code,
                        RedirectUri = Program.XeroSampleMainForm.CallbackUri
                    }).Result;

                    if (response.IsError)
                    {
                        var errorMessage = string.Format("Error: {0}", response.HttpErrorReason);
                        Program.XeroSampleMainForm.Invoke(new Action(() =>
                        {
                            Program.XeroSampleMainForm.SetError(errorMessage);
                        }));

                        var errorContent = String.Format
                            (@"<html><head><h1>Error</h1></head><body><h3>{0}</h3></body></html>", errorMessage);
                        result.Content = errorContent;
                        result.ContentType = "text/html";
                        //throw new Exception(response.Error);
                        return result;
                    }
                    var accessToken = response.AccessToken;
                    var refreshToken = response.RefreshToken;
                    var identityToken = response.IdentityToken;
                    var refreshTokenExpiry = DateTime.Now.ToUniversalTime().AddSeconds(response.ExpiresIn);

                    Program.XeroSampleMainForm.Invoke(new Action(() =>
                    {
                        Program.XeroSampleMainForm.SetSuccess(
                            accessToken
                            , identityToken
                            , refreshToken
                            , refreshTokenExpiry.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK")
                            , state
                            , "Completed. Please selected a tenant then save the tokens to use in your application.");
                    }));

                    var htmlContent = String.Format
                        (@"<html><head><h1>Completed</h1></head><body><h3>Check the main form of the application for tokens.</h3></body></html>");
                    result.Content = htmlContent;
                    result.ContentType = "text/html";

                    //var content = String.Format(@"<html><head></head><body>
                    //    <h3>AccessToken</h3><p>{0}</p>
                    //    <h3>RefreshToken</h3><p>{1}</p>
                    //    <h3>IdentityToken</h3><p>{2}</p>
                    //    </body></html>"
                    //    , accessToken
                    //    , refreshToken
                    //    , identityToken);
                    //result.Content = content;
                    //result.ContentType = "text/html";

                }
            }
            catch (Exception ex)
            {
                var errorMessage = string.Format("Error: {0}", ex.Message);
                Program.XeroSampleMainForm.Invoke(new Action(() =>
                {
                    Program.XeroSampleMainForm.SetError(errorMessage);
                }));
            }
            return result;
        }
    }
}
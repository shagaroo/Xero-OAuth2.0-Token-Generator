
namespace XeroSample.TokenGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClientId = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.lblClientSecret = new System.Windows.Forms.Label();
            this.txtCallbackURI = new System.Windows.Forms.TextBox();
            this.lblCallbackUri = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblScopes = new System.Windows.Forms.Label();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.lblAccessToken = new System.Windows.Forms.Label();
            this.txtIdentityToken = new System.Windows.Forms.TextBox();
            this.lblIdentityToken = new System.Windows.Forms.Label();
            this.txtRefreshToken = new System.Windows.Forms.TextBox();
            this.lblRefreshToken = new System.Windows.Forms.Label();
            this.txtRefreshTokenExpiry = new System.Windows.Forms.TextBox();
            this.lblRefreshTokenExpiry = new System.Windows.Forms.Label();
            this.txtReturnedState = new System.Windows.Forms.TextBox();
            this.lblReturnedState = new System.Windows.Forms.Label();
            this.lblTenants = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.lstScopes = new System.Windows.Forms.ListBox();
            this.grpGeneratedResults = new System.Windows.Forms.GroupBox();
            this.lstTenants = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpInputs.SuspendLayout();
            this.grpGeneratedResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(77, 25);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(47, 13);
            this.lblClientId.TabIndex = 0;
            this.lblClientId.Text = "Client ID";
            // 
            // txtClientId
            // 
            this.txtClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientId.Location = new System.Drawing.Point(132, 25);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(393, 20);
            this.txtClientId.TabIndex = 1;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientSecret.Location = new System.Drawing.Point(132, 51);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(393, 20);
            this.txtClientSecret.TabIndex = 3;
            // 
            // lblClientSecret
            // 
            this.lblClientSecret.AutoSize = true;
            this.lblClientSecret.Location = new System.Drawing.Point(57, 51);
            this.lblClientSecret.Name = "lblClientSecret";
            this.lblClientSecret.Size = new System.Drawing.Size(67, 13);
            this.lblClientSecret.TabIndex = 2;
            this.lblClientSecret.Text = "Client Secret";
            // 
            // txtCallbackURI
            // 
            this.txtCallbackURI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCallbackURI.Location = new System.Drawing.Point(132, 77);
            this.txtCallbackURI.Name = "txtCallbackURI";
            this.txtCallbackURI.Size = new System.Drawing.Size(393, 20);
            this.txtCallbackURI.TabIndex = 5;
            this.txtCallbackURI.Text = "http://localhost:5000/api/oauth";
            // 
            // lblCallbackUri
            // 
            this.lblCallbackUri.AutoSize = true;
            this.lblCallbackUri.Location = new System.Drawing.Point(54, 77);
            this.lblCallbackUri.Name = "lblCallbackUri";
            this.lblCallbackUri.Size = new System.Drawing.Size(70, 13);
            this.lblCallbackUri.TabIndex = 4;
            this.lblCallbackUri.Text = "Callback URI";
            // 
            // txtState
            // 
            this.txtState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtState.Location = new System.Drawing.Point(132, 230);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(393, 20);
            this.txtState.TabIndex = 7;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(44, 230);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(80, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State (Optional)";
            // 
            // lblScopes
            // 
            this.lblScopes.AutoSize = true;
            this.lblScopes.Location = new System.Drawing.Point(81, 103);
            this.lblScopes.Name = "lblScopes";
            this.lblScopes.Size = new System.Drawing.Size(43, 13);
            this.lblScopes.TabIndex = 9;
            this.lblScopes.Text = "Scopes";
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccessToken.Location = new System.Drawing.Point(152, 27);
            this.txtAccessToken.Multiline = true;
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.ReadOnly = true;
            this.txtAccessToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAccessToken.Size = new System.Drawing.Size(373, 89);
            this.txtAccessToken.TabIndex = 11;
            // 
            // lblAccessToken
            // 
            this.lblAccessToken.AutoSize = true;
            this.lblAccessToken.Location = new System.Drawing.Point(70, 27);
            this.lblAccessToken.Name = "lblAccessToken";
            this.lblAccessToken.Size = new System.Drawing.Size(76, 13);
            this.lblAccessToken.TabIndex = 10;
            this.lblAccessToken.Text = "Access Token";
            // 
            // txtIdentityToken
            // 
            this.txtIdentityToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdentityToken.Location = new System.Drawing.Point(152, 122);
            this.txtIdentityToken.Multiline = true;
            this.txtIdentityToken.Name = "txtIdentityToken";
            this.txtIdentityToken.ReadOnly = true;
            this.txtIdentityToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIdentityToken.Size = new System.Drawing.Size(373, 83);
            this.txtIdentityToken.TabIndex = 13;
            // 
            // lblIdentityToken
            // 
            this.lblIdentityToken.AutoSize = true;
            this.lblIdentityToken.Location = new System.Drawing.Point(71, 122);
            this.lblIdentityToken.Name = "lblIdentityToken";
            this.lblIdentityToken.Size = new System.Drawing.Size(75, 13);
            this.lblIdentityToken.TabIndex = 12;
            this.lblIdentityToken.Text = "Identity Token";
            // 
            // txtRefreshToken
            // 
            this.txtRefreshToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefreshToken.Location = new System.Drawing.Point(152, 211);
            this.txtRefreshToken.Multiline = true;
            this.txtRefreshToken.Name = "txtRefreshToken";
            this.txtRefreshToken.ReadOnly = true;
            this.txtRefreshToken.Size = new System.Drawing.Size(373, 20);
            this.txtRefreshToken.TabIndex = 15;
            // 
            // lblRefreshToken
            // 
            this.lblRefreshToken.AutoSize = true;
            this.lblRefreshToken.Location = new System.Drawing.Point(68, 211);
            this.lblRefreshToken.Name = "lblRefreshToken";
            this.lblRefreshToken.Size = new System.Drawing.Size(78, 13);
            this.lblRefreshToken.TabIndex = 14;
            this.lblRefreshToken.Text = "Refresh Token";
            // 
            // txtRefreshTokenExpiry
            // 
            this.txtRefreshTokenExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefreshTokenExpiry.Location = new System.Drawing.Point(152, 237);
            this.txtRefreshTokenExpiry.Name = "txtRefreshTokenExpiry";
            this.txtRefreshTokenExpiry.ReadOnly = true;
            this.txtRefreshTokenExpiry.Size = new System.Drawing.Size(373, 20);
            this.txtRefreshTokenExpiry.TabIndex = 17;
            // 
            // lblRefreshTokenExpiry
            // 
            this.lblRefreshTokenExpiry.AutoSize = true;
            this.lblRefreshTokenExpiry.Location = new System.Drawing.Point(6, 237);
            this.lblRefreshTokenExpiry.Name = "lblRefreshTokenExpiry";
            this.lblRefreshTokenExpiry.Size = new System.Drawing.Size(140, 13);
            this.lblRefreshTokenExpiry.TabIndex = 16;
            this.lblRefreshTokenExpiry.Text = "Refresh Token Expiry (UTC)";
            // 
            // txtReturnedState
            // 
            this.txtReturnedState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReturnedState.Location = new System.Drawing.Point(152, 263);
            this.txtReturnedState.Name = "txtReturnedState";
            this.txtReturnedState.ReadOnly = true;
            this.txtReturnedState.Size = new System.Drawing.Size(373, 20);
            this.txtReturnedState.TabIndex = 19;
            // 
            // lblReturnedState
            // 
            this.lblReturnedState.AutoSize = true;
            this.lblReturnedState.Location = new System.Drawing.Point(67, 263);
            this.lblReturnedState.Name = "lblReturnedState";
            this.lblReturnedState.Size = new System.Drawing.Size(79, 13);
            this.lblReturnedState.TabIndex = 18;
            this.lblReturnedState.Text = "Returned State";
            // 
            // lblTenants
            // 
            this.lblTenants.AutoSize = true;
            this.lblTenants.Location = new System.Drawing.Point(100, 289);
            this.lblTenants.Name = "lblTenants";
            this.lblTenants.Size = new System.Drawing.Size(46, 13);
            this.lblTenants.TabIndex = 21;
            this.lblTenants.Text = "Tenants";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(436, 256);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(88, 22);
            this.btnGenerate.TabIndex = 24;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.btnGenerate);
            this.grpInputs.Controls.Add(this.lblClientId);
            this.grpInputs.Controls.Add(this.lblScopes);
            this.grpInputs.Controls.Add(this.txtState);
            this.grpInputs.Controls.Add(this.lstScopes);
            this.grpInputs.Controls.Add(this.lblState);
            this.grpInputs.Controls.Add(this.txtCallbackURI);
            this.grpInputs.Controls.Add(this.txtClientId);
            this.grpInputs.Controls.Add(this.lblCallbackUri);
            this.grpInputs.Controls.Add(this.lblClientSecret);
            this.grpInputs.Controls.Add(this.txtClientSecret);
            this.grpInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInputs.Location = new System.Drawing.Point(0, 0);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(548, 284);
            this.grpInputs.TabIndex = 22;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Inputs - Please Enter";
            // 
            // lstScopes
            // 
            this.lstScopes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstScopes.FormattingEnabled = true;
            this.lstScopes.Location = new System.Drawing.Point(132, 103);
            this.lstScopes.Name = "lstScopes";
            this.lstScopes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstScopes.Size = new System.Drawing.Size(393, 121);
            this.lstScopes.TabIndex = 8;
            // 
            // grpGeneratedResults
            // 
            this.grpGeneratedResults.Controls.Add(this.lstTenants);
            this.grpGeneratedResults.Controls.Add(this.lblAccessToken);
            this.grpGeneratedResults.Controls.Add(this.txtAccessToken);
            this.grpGeneratedResults.Controls.Add(this.lblRefreshTokenExpiry);
            this.grpGeneratedResults.Controls.Add(this.lblTenants);
            this.grpGeneratedResults.Controls.Add(this.txtRefreshTokenExpiry);
            this.grpGeneratedResults.Controls.Add(this.lblIdentityToken);
            this.grpGeneratedResults.Controls.Add(this.txtRefreshToken);
            this.grpGeneratedResults.Controls.Add(this.lblReturnedState);
            this.grpGeneratedResults.Controls.Add(this.txtIdentityToken);
            this.grpGeneratedResults.Controls.Add(this.lblRefreshToken);
            this.grpGeneratedResults.Controls.Add(this.txtReturnedState);
            this.grpGeneratedResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGeneratedResults.Location = new System.Drawing.Point(0, 284);
            this.grpGeneratedResults.Name = "grpGeneratedResults";
            this.grpGeneratedResults.Size = new System.Drawing.Size(548, 394);
            this.grpGeneratedResults.TabIndex = 24;
            this.grpGeneratedResults.TabStop = false;
            this.grpGeneratedResults.Text = "Generated Results";
            // 
            // lstTenants
            // 
            this.lstTenants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTenants.FormattingEnabled = true;
            this.lstTenants.Location = new System.Drawing.Point(152, 289);
            this.lstTenants.Name = "lstTenants";
            this.lstTenants.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTenants.Size = new System.Drawing.Size(373, 95);
            this.lstTenants.TabIndex = 22;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.Location = new System.Drawing.Point(0, 678);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(548, 19);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.Text = "lblInfo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 697);
            this.Controls.Add(this.grpGeneratedResults);
            this.Controls.Add(this.grpInputs);
            this.Controls.Add(this.lblInfo);
            this.Name = "MainForm";
            this.Text = "Xero Token Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.grpGeneratedResults.ResumeLayout(false);
            this.grpGeneratedResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label lblClientSecret;
        private System.Windows.Forms.TextBox txtCallbackURI;
        private System.Windows.Forms.Label lblCallbackUri;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblScopes;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.Label lblAccessToken;
        private System.Windows.Forms.TextBox txtIdentityToken;
        private System.Windows.Forms.Label lblIdentityToken;
        private System.Windows.Forms.TextBox txtRefreshToken;
        private System.Windows.Forms.Label lblRefreshToken;
        private System.Windows.Forms.TextBox txtRefreshTokenExpiry;
        private System.Windows.Forms.Label lblRefreshTokenExpiry;
        private System.Windows.Forms.TextBox txtReturnedState;
        private System.Windows.Forms.Label lblReturnedState;
        private System.Windows.Forms.Label lblTenants;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.GroupBox grpGeneratedResults;
        private System.Windows.Forms.ListBox lstScopes;
        private System.Windows.Forms.ListBox lstTenants;
        private System.Windows.Forms.Label lblInfo;
    }
}


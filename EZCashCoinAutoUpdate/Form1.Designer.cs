namespace EZCashCoinAutoUpdate
{
    partial class CoinServiceAutoUpdate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinServiceAutoUpdate));
            lblStatus = new Label();
            btnCancel = new Button();
            txtServiceInstallPath = new TextBox();
            lblService = new Label();
            txtServiceDownloadURL = new TextBox();
            lblVersion = new Label();
            btnSaveConfiguration = new Button();
            folderselectdialog = new FolderBrowserDialog();
            btnFolderSelect = new Button();
            txtUserName = new TextBox();
            lblUsername = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnShowPassword = new Button();
            toolTipServiceInstallPath = new ToolTip(components);
            toolTipSaveConfiguration = new ToolTip(components);
            toolTipCloseApplication = new ToolTip(components);
            toolTipShowPassword = new ToolTip(components);
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblStatus.ForeColor = SystemColors.HighlightText;
            lblStatus.Location = new Point(28, 90);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 14);
            lblStatus.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Verdana", 9F);
            btnCancel.Location = new Point(190, 240);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(76, 30);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            toolTipCloseApplication.SetToolTip(btnCancel, "Close Application");
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtServiceInstallPath
            // 
            txtServiceInstallPath.Font = new Font("Verdana", 9F);
            txtServiceInstallPath.Location = new Point(179, 190);
            txtServiceInstallPath.Name = "txtServiceInstallPath";
            txtServiceInstallPath.Size = new Size(152, 22);
            txtServiceInstallPath.TabIndex = 12;
            txtServiceInstallPath.Visible = false;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.BackColor = Color.Transparent;
            lblService.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblService.ForeColor = SystemColors.HighlightText;
            lblService.Location = new Point(14, 193);
            lblService.Name = "lblService";
            lblService.Size = new Size(137, 14);
            lblService.TabIndex = 11;
            lblService.Text = "Service Install Path";
            lblService.Visible = false;
            // 
            // txtServiceDownloadURL
            // 
            txtServiceDownloadURL.Font = new Font("Verdana", 9F);
            txtServiceDownloadURL.Location = new Point(179, 65);
            txtServiceDownloadURL.Name = "txtServiceDownloadURL";
            txtServiceDownloadURL.Size = new Size(152, 22);
            txtServiceDownloadURL.TabIndex = 10;
            txtServiceDownloadURL.Visible = false;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblVersion.ForeColor = SystemColors.HighlightText;
            lblVersion.Location = new Point(12, 68);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(158, 14);
            lblVersion.TabIndex = 9;
            lblVersion.Text = "Service Download URL";
            lblVersion.Visible = false;
            // 
            // btnSaveConfiguration
            // 
            btnSaveConfiguration.Cursor = Cursors.Hand;
            btnSaveConfiguration.Font = new Font("Verdana", 9F);
            btnSaveConfiguration.Location = new Point(100, 240);
            btnSaveConfiguration.Name = "btnSaveConfiguration";
            btnSaveConfiguration.Size = new Size(76, 30);
            btnSaveConfiguration.TabIndex = 8;
            btnSaveConfiguration.Text = "Save";
            toolTipSaveConfiguration.SetToolTip(btnSaveConfiguration, "Save Configuration");
            btnSaveConfiguration.UseVisualStyleBackColor = true;
            btnSaveConfiguration.Visible = false;
            btnSaveConfiguration.Click += btnSaveConfiguration_Click;
            // 
            // btnFolderSelect
            // 
            btnFolderSelect.BackgroundImage = (Image)resources.GetObject("btnFolderSelect.BackgroundImage");
            btnFolderSelect.BackgroundImageLayout = ImageLayout.Zoom;
            btnFolderSelect.Cursor = Cursors.Hand;
            btnFolderSelect.Location = new Point(335, 191);
            btnFolderSelect.Name = "btnFolderSelect";
            btnFolderSelect.Size = new Size(26, 23);
            btnFolderSelect.TabIndex = 15;
            toolTipServiceInstallPath.SetToolTip(btnFolderSelect, "Select Service install path");
            btnFolderSelect.UseVisualStyleBackColor = true;
            btnFolderSelect.Visible = false;
            btnFolderSelect.Click += btnFolderSelect_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Verdana", 9F);
            txtUserName.Location = new Point(179, 105);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(152, 22);
            txtUserName.TabIndex = 17;
            txtUserName.Visible = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblUsername.ForeColor = SystemColors.HighlightText;
            lblUsername.Location = new Point(14, 108);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 14);
            lblUsername.TabIndex = 16;
            lblUsername.Text = "User Name";
            lblUsername.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 9F);
            txtPassword.Location = new Point(179, 148);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(152, 22);
            txtPassword.TabIndex = 19;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblPassword.ForeColor = SystemColors.HighlightText;
            lblPassword.Location = new Point(14, 151);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 14);
            lblPassword.TabIndex = 18;
            lblPassword.Text = "Password";
            lblPassword.Visible = false;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackgroundImage = (Image)resources.GetObject("btnShowPassword.BackgroundImage");
            btnShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowPassword.Cursor = Cursors.Hand;
            btnShowPassword.Location = new Point(335, 148);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(26, 23);
            btnShowPassword.TabIndex = 20;
            toolTipShowPassword.SetToolTip(btnShowPassword, "Show Password");
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Visible = false;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // CoinServiceAutoUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(374, 281);
            Controls.Add(btnShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUsername);
            Controls.Add(lblStatus);
            Controls.Add(btnCancel);
            Controls.Add(txtServiceInstallPath);
            Controls.Add(lblService);
            Controls.Add(txtServiceDownloadURL);
            Controls.Add(lblVersion);
            Controls.Add(btnSaveConfiguration);
            Controls.Add(btnFolderSelect);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CoinServiceAutoUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EZCash Coin Service Auto Update";
            Load += AutoUpdater_LoadAsync;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnCancel;
        private TextBox txtServiceInstallPath;
        private Label lblService;
        private TextBox txtServiceDownloadURL;
        private Label lblVersion;
        private Button btnSaveConfiguration;
        private FolderBrowserDialog folderselectdialog;
        private Button btnFolderSelect;
        private TextBox txtUserName;
        private Label lblUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnShowPassword;
        private ToolTip toolTipCloseApplication;
        private ToolTip toolTipSaveConfiguration;
        private ToolTip toolTipServiceInstallPath;
        private ToolTip toolTipShowPassword;
    }
}

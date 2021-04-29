namespace RestaurantManagement
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUserId = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(195, 271);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 58);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(195, 336);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroLabel1.Location = new System.Drawing.Point(49, 129);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "User Id";
            // 
            // txtUserId
            // 
            // 
            // 
            // 
            this.txtUserId.CustomButton.Image = null;
            this.txtUserId.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtUserId.CustomButton.Name = "";
            this.txtUserId.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserId.CustomButton.TabIndex = 1;
            this.txtUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserId.CustomButton.UseSelectable = true;
            this.txtUserId.CustomButton.Visible = false;
            this.txtUserId.Lines = new string[] {
        "u-001"};
            this.txtUserId.Location = new System.Drawing.Point(195, 131);
            this.txtUserId.MaxLength = 32767;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PasswordChar = '\0';
            this.txtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserId.SelectedText = "";
            this.txtUserId.SelectionLength = 0;
            this.txtUserId.SelectionStart = 0;
            this.txtUserId.ShortcutsEnabled = true;
            this.txtUserId.Size = new System.Drawing.Size(170, 21);
            this.txtUserId.TabIndex = 10;
            this.txtUserId.Text = "u-001";
            this.txtUserId.UseSelectable = true;
            this.txtUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[] {
        "1234"};
            this.txtPassword.Location = new System.Drawing.Point(195, 192);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(170, 21);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "1234";
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.DimGray;
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroLabel2.Location = new System.Drawing.Point(49, 192);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 25);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Password";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestaurantManagement.Properties.Resources.login_png_icon;
            this.BackImage = global::RestaurantManagement.Properties.Resources.login_png_icon;
            this.ClientSize = new System.Drawing.Size(477, 453);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Algerian", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(23, 64, 23, 21);
            this.Text = " Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUserId;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}


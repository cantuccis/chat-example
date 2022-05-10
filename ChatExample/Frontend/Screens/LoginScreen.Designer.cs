namespace Frontend.Screens
{
    partial class LoginScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginCard = new MaterialSkin.Controls.MaterialCard();
            this.messageLbl = new MaterialSkin.Controls.MaterialLabel();
            this.signInBtn = new MaterialSkin.Controls.MaterialButton();
            this.passwordTxt = new MaterialSkin.Controls.MaterialTextBox2();
            this.usernameTxt = new MaterialSkin.Controls.MaterialTextBox2();
            this.loginTitleLbl = new MaterialSkin.Controls.MaterialLabel();
            this.signUpBtn = new MaterialSkin.Controls.MaterialButton();
            this.loginCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginCard
            // 
            this.loginCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginCard.Controls.Add(this.messageLbl);
            this.loginCard.Controls.Add(this.signInBtn);
            this.loginCard.Controls.Add(this.passwordTxt);
            this.loginCard.Controls.Add(this.usernameTxt);
            this.loginCard.Controls.Add(this.loginTitleLbl);
            this.loginCard.Depth = 0;
            this.loginCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginCard.Location = new System.Drawing.Point(181, 80);
            this.loginCard.Margin = new System.Windows.Forms.Padding(14);
            this.loginCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginCard.Name = "loginCard";
            this.loginCard.Padding = new System.Windows.Forms.Padding(14);
            this.loginCard.Size = new System.Drawing.Size(584, 416);
            this.loginCard.TabIndex = 0;
            // 
            // messageLbl
            // 
            this.messageLbl.Depth = 0;
            this.messageLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.messageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.messageLbl.HighEmphasis = true;
            this.messageLbl.Location = new System.Drawing.Point(14, 379);
            this.messageLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(556, 23);
            this.messageLbl.TabIndex = 6;
            this.messageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLbl.UseAccent = true;
            // 
            // signInBtn
            // 
            this.signInBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signInBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signInBtn.Depth = 0;
            this.signInBtn.HighEmphasis = true;
            this.signInBtn.Icon = null;
            this.signInBtn.Location = new System.Drawing.Point(256, 328);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signInBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signInBtn.Size = new System.Drawing.Size(73, 36);
            this.signInBtn.TabIndex = 3;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.signInBtn.UseAccentColor = false;
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.AnimateReadOnly = false;
            this.passwordTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTxt.Depth = 0;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTxt.HideSelection = true;
            this.passwordTxt.Hint = "Password";
            this.passwordTxt.LeadingIcon = global::Frontend.Properties.Resources.key;
            this.passwordTxt.Location = new System.Drawing.Point(88, 240);
            this.passwordTxt.MaxLength = 32767;
            this.passwordTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.PrefixSuffixText = null;
            this.passwordTxt.ReadOnly = false;
            this.passwordTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.SelectionLength = 0;
            this.passwordTxt.SelectionStart = 0;
            this.passwordTxt.ShortcutsEnabled = true;
            this.passwordTxt.Size = new System.Drawing.Size(408, 48);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.TabStop = false;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTxt.TrailingIcon = null;
            this.passwordTxt.UseSystemPasswordChar = false;
            // 
            // usernameTxt
            // 
            this.usernameTxt.AnimateReadOnly = false;
            this.usernameTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usernameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameTxt.Depth = 0;
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameTxt.HideSelection = true;
            this.usernameTxt.Hint = "Username";
            this.usernameTxt.LeadingIcon = global::Frontend.Properties.Resources.user;
            this.usernameTxt.Location = new System.Drawing.Point(88, 176);
            this.usernameTxt.MaxLength = 32767;
            this.usernameTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PrefixSuffixText = null;
            this.usernameTxt.ReadOnly = false;
            this.usernameTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.SelectionLength = 0;
            this.usernameTxt.SelectionStart = 0;
            this.usernameTxt.ShortcutsEnabled = true;
            this.usernameTxt.Size = new System.Drawing.Size(408, 48);
            this.usernameTxt.TabIndex = 1;
            this.usernameTxt.TabStop = false;
            this.usernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTxt.TrailingIcon = null;
            this.usernameTxt.UseSystemPasswordChar = false;
            // 
            // loginTitleLbl
            // 
            this.loginTitleLbl.Depth = 0;
            this.loginTitleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginTitleLbl.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.loginTitleLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.loginTitleLbl.Location = new System.Drawing.Point(14, 14);
            this.loginTitleLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTitleLbl.Name = "loginTitleLbl";
            this.loginTitleLbl.Size = new System.Drawing.Size(556, 106);
            this.loginTitleLbl.TabIndex = 0;
            this.loginTitleLbl.Text = "Log in";
            this.loginTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUpBtn
            // 
            this.signUpBtn.AutoSize = false;
            this.signUpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signUpBtn.Depth = 0;
            this.signUpBtn.HighEmphasis = true;
            this.signUpBtn.Icon = null;
            this.signUpBtn.Location = new System.Drawing.Point(421, 520);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signUpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signUpBtn.Size = new System.Drawing.Size(104, 36);
            this.signUpBtn.TabIndex = 4;
            this.signUpBtn.Text = "or sign up";
            this.signUpBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.signUpBtn.UseAccentColor = false;
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.loginCard);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(947, 616);
            this.loginCard.ResumeLayout(false);
            this.loginCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard loginCard;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTxt;
        private MaterialSkin.Controls.MaterialTextBox2 usernameTxt;
        private MaterialSkin.Controls.MaterialLabel loginTitleLbl;
        private MaterialSkin.Controls.MaterialButton signInBtn;
        private MaterialSkin.Controls.MaterialButton signUpBtn;
        private MaterialSkin.Controls.MaterialLabel messageLbl;
    }
}

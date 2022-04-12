namespace Frontend.Screens
{
    partial class SignUpScreen
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
            this.signUpBtn = new MaterialSkin.Controls.MaterialButton();
            this.signUpTitleLbl = new MaterialSkin.Controls.MaterialLabel();
            this.emailTxt = new MaterialSkin.Controls.MaterialTextBox2();
            this.passwordTxt = new MaterialSkin.Controls.MaterialTextBox2();
            this.usernameTxt = new MaterialSkin.Controls.MaterialTextBox2();
            this.orSignInButton = new MaterialSkin.Controls.MaterialButton();
            this.loginCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginCard
            // 
            this.loginCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginCard.Controls.Add(this.emailTxt);
            this.loginCard.Controls.Add(this.signUpBtn);
            this.loginCard.Controls.Add(this.passwordTxt);
            this.loginCard.Controls.Add(this.usernameTxt);
            this.loginCard.Controls.Add(this.signUpTitleLbl);
            this.loginCard.Depth = 0;
            this.loginCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginCard.Location = new System.Drawing.Point(181, 32);
            this.loginCard.Margin = new System.Windows.Forms.Padding(14);
            this.loginCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginCard.Name = "loginCard";
            this.loginCard.Padding = new System.Windows.Forms.Padding(14);
            this.loginCard.Size = new System.Drawing.Size(584, 480);
            this.loginCard.TabIndex = 1;
            // 
            // signUpBtn
            // 
            this.signUpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signUpBtn.Depth = 0;
            this.signUpBtn.HighEmphasis = true;
            this.signUpBtn.Icon = null;
            this.signUpBtn.Location = new System.Drawing.Point(256, 400);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signUpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signUpBtn.Size = new System.Drawing.Size(77, 36);
            this.signUpBtn.TabIndex = 3;
            this.signUpBtn.Text = "Sign up";
            this.signUpBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.signUpBtn.UseAccentColor = false;
            this.signUpBtn.UseVisualStyleBackColor = true;
            // 
            // signUpTitleLbl
            // 
            this.signUpTitleLbl.Depth = 0;
            this.signUpTitleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.signUpTitleLbl.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.signUpTitleLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.signUpTitleLbl.Location = new System.Drawing.Point(14, 14);
            this.signUpTitleLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpTitleLbl.Name = "signUpTitleLbl";
            this.signUpTitleLbl.Size = new System.Drawing.Size(556, 106);
            this.signUpTitleLbl.TabIndex = 0;
            this.signUpTitleLbl.Text = "Sign Up";
            this.signUpTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTxt
            // 
            this.emailTxt.AnimateReadOnly = false;
            this.emailTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emailTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailTxt.Depth = 0;
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailTxt.HideSelection = true;
            this.emailTxt.Hint = "Email";
            this.emailTxt.LeadingIcon = global::Frontend.Properties.Resources.email;
            this.emailTxt.Location = new System.Drawing.Point(88, 304);
            this.emailTxt.MaxLength = 32767;
            this.emailTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PrefixSuffixText = null;
            this.emailTxt.ReadOnly = false;
            this.emailTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailTxt.SelectedText = "";
            this.emailTxt.SelectionLength = 0;
            this.emailTxt.SelectionStart = 0;
            this.emailTxt.ShortcutsEnabled = true;
            this.emailTxt.Size = new System.Drawing.Size(408, 48);
            this.emailTxt.TabIndex = 4;
            this.emailTxt.TabStop = false;
            this.emailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTxt.TrailingIcon = null;
            this.emailTxt.UseSystemPasswordChar = false;
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
            // orSignInButton
            // 
            this.orSignInButton.AutoSize = false;
            this.orSignInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orSignInButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.orSignInButton.Depth = 0;
            this.orSignInButton.HighEmphasis = true;
            this.orSignInButton.Icon = null;
            this.orSignInButton.Location = new System.Drawing.Point(427, 528);
            this.orSignInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.orSignInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.orSignInButton.Name = "orSignInButton";
            this.orSignInButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.orSignInButton.Size = new System.Drawing.Size(93, 36);
            this.orSignInButton.TabIndex = 5;
            this.orSignInButton.Text = "or sign in";
            this.orSignInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.orSignInButton.UseAccentColor = false;
            this.orSignInButton.UseVisualStyleBackColor = true;
            this.orSignInButton.Click += new System.EventHandler(this.orSignInButton_Click);
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orSignInButton);
            this.Controls.Add(this.loginCard);
            this.Name = "SignUpScreen";
            this.Size = new System.Drawing.Size(947, 616);
            this.loginCard.ResumeLayout(false);
            this.loginCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard loginCard;
        private MaterialSkin.Controls.MaterialTextBox2 emailTxt;
        private MaterialSkin.Controls.MaterialButton signUpBtn;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTxt;
        private MaterialSkin.Controls.MaterialTextBox2 usernameTxt;
        private MaterialSkin.Controls.MaterialLabel signUpTitleLbl;
        private MaterialSkin.Controls.MaterialButton orSignInButton;
    }
}

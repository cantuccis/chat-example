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
            this.loginTitleLbl = new MaterialSkin.Controls.MaterialLabel();
            this.usernameTxt = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.signInBtn = new MaterialSkin.Controls.MaterialButton();
            this.signUpBtn = new MaterialSkin.Controls.MaterialButton();
            this.loginCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginCard
            // 
            this.loginCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginCard.Controls.Add(this.signInBtn);
            this.loginCard.Controls.Add(this.materialTextBox21);
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
            // usernameTxt
            // 
            this.usernameTxt.AnimateReadOnly = false;
            this.usernameTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usernameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameTxt.Depth = 0;
            this.usernameTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.Hint = "Password";
            this.materialTextBox21.LeadingIcon = global::Frontend.Properties.Resources.key;
            this.materialTextBox21.Location = new System.Drawing.Point(88, 240);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '*';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(408, 48);
            this.materialTextBox21.TabIndex = 2;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // signInBtn
            // 
            this.signInBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signInBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signInBtn.Depth = 0;
            this.signInBtn.HighEmphasis = true;
            this.signInBtn.Icon = null;
            this.signInBtn.Location = new System.Drawing.Point(256, 344);
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
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialTextBox2 usernameTxt;
        private MaterialSkin.Controls.MaterialLabel loginTitleLbl;
        private MaterialSkin.Controls.MaterialButton signInBtn;
        private MaterialSkin.Controls.MaterialButton signUpBtn;
    }
}

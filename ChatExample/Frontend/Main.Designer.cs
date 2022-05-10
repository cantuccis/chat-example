namespace Frontend
{
    partial class Main
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.chatTabPage = new System.Windows.Forms.TabPage();
            this.logoutTabPage = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.chatTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(953, 625);
            this.mainPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bottomPanel.Location = new System.Drawing.Point(118, 765);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(950, 58);
            this.bottomPanel.TabIndex = 1;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.chatTabPage);
            this.materialTabControl1.Controls.Add(this.logoutTabPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(93, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(967, 657);
            this.materialTabControl1.TabIndex = 2;
            this.materialTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.materialTabControl1_Selected);
            // 
            // chatTabPage
            // 
            this.chatTabPage.BackColor = System.Drawing.Color.White;
            this.chatTabPage.Controls.Add(this.mainPanel);
            this.chatTabPage.Location = new System.Drawing.Point(4, 22);
            this.chatTabPage.Name = "chatTabPage";
            this.chatTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.chatTabPage.Size = new System.Drawing.Size(959, 631);
            this.chatTabPage.TabIndex = 0;
            this.chatTabPage.Text = "Chat";
            // 
            // logoutTabPage
            // 
            this.logoutTabPage.BackColor = System.Drawing.Color.White;
            this.logoutTabPage.Location = new System.Drawing.Point(4, 22);
            this.logoutTabPage.Name = "logoutTabPage";
            this.logoutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.logoutTabPage.Size = new System.Drawing.Size(959, 631);
            this.logoutTabPage.TabIndex = 1;
            this.logoutTabPage.Text = "Log out";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 957);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.bottomPanel);
            this.DrawerTabControl = this.materialTabControl1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Chat App";
            this.materialTabControl1.ResumeLayout(false);
            this.chatTabPage.ResumeLayout(false);
            this.chatTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage chatTabPage;
        private System.Windows.Forms.TabPage logoutTabPage;
    }
}


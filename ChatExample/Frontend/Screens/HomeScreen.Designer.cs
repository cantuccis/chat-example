﻿namespace Frontend.Screens
{
    partial class HomeScreen
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
            this.chatPanelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // chatPanelContainer
            // 
            this.chatPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.chatPanelContainer.Name = "chatPanelContainer";
            this.chatPanelContainer.Size = new System.Drawing.Size(947, 616);
            this.chatPanelContainer.TabIndex = 0;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chatPanelContainer);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(947, 616);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chatPanelContainer;
    }
}

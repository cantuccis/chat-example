namespace Frontend.UserControls.InAppNotification
{
    partial class Notification
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.notificationLbl = new MaterialSkin.Controls.MaterialLabel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.notificationLbl);
            this.materialCard1.Controls.Add(this.icon);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(6, 6);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(529, 51);
            this.materialCard1.TabIndex = 1;
            // 
            // notificationLbl
            // 
            this.notificationLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.notificationLbl.AutoSize = true;
            this.notificationLbl.Depth = 0;
            this.notificationLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.notificationLbl.Location = new System.Drawing.Point(50, 17);
            this.notificationLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.notificationLbl.Name = "notificationLbl";
            this.notificationLbl.Size = new System.Drawing.Size(1, 0);
            this.notificationLbl.TabIndex = 1;
            this.notificationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // icon
            // 
            this.icon.Image = global::Frontend.Properties.Resources.warning;
            this.icon.Location = new System.Drawing.Point(8, 10);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(32, 32);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "Notification";
            this.Size = new System.Drawing.Size(541, 64);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        protected System.Windows.Forms.PictureBox icon;
        private MaterialSkin.Controls.MaterialLabel notificationLbl;
    }
}

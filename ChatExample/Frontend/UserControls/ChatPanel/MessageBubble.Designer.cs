namespace Frontend.UserControls.ChatPanel
{
    partial class MessageBubble
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
            this.messageLbl = new MaterialSkin.Controls.MaterialLabel();
            this.profilePicImg = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicImg)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblName);
            this.materialCard1.Controls.Add(this.messageLbl);
            this.materialCard1.Controls.Add(this.profilePicImg);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(16, 8);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(496, 64);
            this.materialCard1.TabIndex = 0;
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Depth = 0;
            this.messageLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.messageLbl.Location = new System.Drawing.Point(72, 24);
            this.messageLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(1, 0);
            this.messageLbl.TabIndex = 1;
            // 
            // profilePicImg
            // 
            this.profilePicImg.Location = new System.Drawing.Point(8, 8);
            this.profilePicImg.Name = "profilePicImg";
            this.profilePicImg.Size = new System.Drawing.Size(48, 48);
            this.profilePicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicImg.TabIndex = 0;
            this.profilePicImg.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(64, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 2;
            // 
            // MessageBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "MessageBubble";
            this.Size = new System.Drawing.Size(527, 83);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel messageLbl;
        private System.Windows.Forms.PictureBox profilePicImg;
        private System.Windows.Forms.Label lblName;
    }
}

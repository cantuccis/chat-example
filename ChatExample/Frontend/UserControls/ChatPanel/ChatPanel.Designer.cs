namespace Frontend.UserControls.ChatPanel
{
    partial class ChatPanel
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
            this.txtMessage = new MaterialSkin.Controls.MaterialTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.chatList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.AnimateReadOnly = false;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Depth = 0;
            this.txtMessage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMessage.Hint = "Write a message...";
            this.txtMessage.LeadingIcon = null;
            this.txtMessage.Location = new System.Drawing.Point(16, 552);
            this.txtMessage.MaxLength = 50;
            this.txtMessage.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMessage.Multiline = false;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(872, 50);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "";
            this.txtMessage.TrailingIcon = null;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // sendBtn
            // 
            this.sendBtn.BackgroundImage = global::Frontend.Properties.Resources.send;
            this.sendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendBtn.Location = new System.Drawing.Point(896, 552);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(48, 48);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // chatList
            // 
            this.chatList.AutoScroll = true;
            this.chatList.Location = new System.Drawing.Point(0, 40);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(944, 512);
            this.chatList.TabIndex = 3;
            // 
            // ChatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chatList);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.txtMessage);
            this.Name = "ChatPanel";
            this.Size = new System.Drawing.Size(947, 616);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtMessage;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.FlowLayoutPanel chatList;
    }
}

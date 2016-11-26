namespace DarkChessClient
{
    partial class ConnectDialog
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
            this.ServerAddress = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.IPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServerAddress
            // 
            this.ServerAddress.Location = new System.Drawing.Point(15, 25);
            this.ServerAddress.Name = "ServerAddress";
            this.ServerAddress.Size = new System.Drawing.Size(254, 20);
            this.ServerAddress.TabIndex = 0;
            this.ServerAddress.UseWaitCursor = true;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(275, 23);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 1;
            this.ConnectBtn.Text = "connect\r\n\r\n";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.UseWaitCursor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.OnConnect);
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(12, 9);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(120, 13);
            this.IPLabel.TabIndex = 2;
            this.IPLabel.Text = "Type IP of game server:";
            this.IPLabel.UseWaitCursor = true;
            // 
            // ConnectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 61);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.ServerAddress);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectDialog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "connect";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerAddress;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label IPLabel;
    }
}
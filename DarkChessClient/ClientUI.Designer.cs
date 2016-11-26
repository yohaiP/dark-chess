namespace DarkChessClient
{
    partial class DarkChessClient
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.XPointerBoardLocationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.YPointerBoardLocationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.turnNotificationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.promotionNotificationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.board = new System.Windows.Forms.PictureBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XPointerBoardLocationStatusLabel,
            this.YPointerBoardLocationStatusLabel,
            this.turnNotificationLabel,
            this.promotionNotificationLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 637);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(554, 24);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // XPointerBoardLocationStatusLabel
            // 
            this.XPointerBoardLocationStatusLabel.Name = "XPointerBoardLocationStatusLabel";
            this.XPointerBoardLocationStatusLabel.Size = new System.Drawing.Size(45, 19);
            this.XPointerBoardLocationStatusLabel.Text = "BoardX";
            // 
            // YPointerBoardLocationStatusLabel
            // 
            this.YPointerBoardLocationStatusLabel.Name = "YPointerBoardLocationStatusLabel";
            this.YPointerBoardLocationStatusLabel.Size = new System.Drawing.Size(45, 19);
            this.YPointerBoardLocationStatusLabel.Text = "BoardY";
            // 
            // turnNotificationLabel
            // 
            this.turnNotificationLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.turnNotificationLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.turnNotificationLabel.ForeColor = System.Drawing.Color.Blue;
            this.turnNotificationLabel.Name = "turnNotificationLabel";
            this.turnNotificationLabel.Size = new System.Drawing.Size(65, 19);
            this.turnNotificationLabel.Text = "your turn?";
            this.turnNotificationLabel.ToolTipText = "its flashing blue when its your turn to play";
            // 
            // promotionNotificationLabel
            // 
            this.promotionNotificationLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.promotionNotificationLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.promotionNotificationLabel.ForeColor = System.Drawing.Color.Red;
            this.promotionNotificationLabel.Name = "promotionNotificationLabel";
            this.promotionNotificationLabel.Size = new System.Drawing.Size(164, 19);
            this.promotionNotificationLabel.Text = "promotion has been occured";
            this.promotionNotificationLabel.ToolTipText = "Notifications about pawn promotions goes here";
            // 
            // board
            // 
            this.board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.board.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board.Cursor = System.Windows.Forms.Cursors.Default;
            this.board.Image = global::DarkChessClient.Properties.Resources.board;
            this.board.Location = new System.Drawing.Point(0, 24);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(550, 550);
            this.board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.board.TabIndex = 2;
            this.board.TabStop = false;
            this.board.Click += new System.EventHandler(this.board_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(12, 580);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 3;
            this.ConnectBtn.Text = "Connect...";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // DarkChessClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(554, 661);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.board);
            this.Controls.Add(this.statusStrip);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "DarkChessClient";
            this.Text = "DarkChess client";
            this.Load += new System.EventHandler(this.DarkChessClient_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel XPointerBoardLocationStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel YPointerBoardLocationStatusLabel;

        public System.Windows.Forms.PictureBox board;

        private System.Windows.Forms.ToolStripStatusLabel turnNotificationLabel;
        private System.Windows.Forms.ToolStripStatusLabel promotionNotificationLabel;
        private System.Windows.Forms.Button ConnectBtn;
    }
}


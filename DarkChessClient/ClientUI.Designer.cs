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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.XPointerBoardLocationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.YPointerBoardLocationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.turnNotificationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.promotionNotificationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.board = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(554, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.connectToolStripMenuItem.Text = "connect...";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XPointerBoardLocationStatusLabel,
            this.YPointerBoardLocationStatusLabel,
            this.turnNotificationLabel,
            this.promotionNotificationLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
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
            this.board.BackgroundImage = System.Drawing.Image.FromFile(@"chess graphics/board.png");
            this.board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.board.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board.Cursor = System.Windows.Forms.Cursors.Default;
            this.board.Location = new System.Drawing.Point(0, 24);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(550, 550);
            this.board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.board.TabIndex = 2;
            this.board.TabStop = false;
            this.board.Click += board_Click;
            // 
            // DarkChessClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(554, 603);
            this.Controls.Add(this.board);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "DarkChessClient";
            this.Text = "DarkChess client";
            this.Load += new System.EventHandler(this.DarkChessClient_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel XPointerBoardLocationStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel YPointerBoardLocationStatusLabel;

        public System.Windows.Forms.PictureBox board;

        private System.Windows.Forms.ToolStripStatusLabel turnNotificationLabel;
        private System.Windows.Forms.ToolStripStatusLabel promotionNotificationLabel;
    }
}


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
            this.pointerBoardLocationStrip = new System.Windows.Forms.StatusStrip();
            this.XPointerBoardLocationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.YPointerBoardLocationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.board = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.pointerBoardLocationStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.connectToolStripMenuItem.Text = "connect...";
            // 
            // pointerBoardLocationStrip
            // 
            this.pointerBoardLocationStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XPointerBoardLocationStatusLabel,
            this.YPointerBoardLocationStatusLabel});
            this.pointerBoardLocationStrip.Location = new System.Drawing.Point(0, 581);
            this.pointerBoardLocationStrip.Name = "pointerBoardLocationStrip";
            this.pointerBoardLocationStrip.Size = new System.Drawing.Size(784, 22);
            this.pointerBoardLocationStrip.TabIndex = 1;
            this.pointerBoardLocationStrip.Text = "statusStrip1";
            // 
            // XPointerBoardLocationStatusLabel
            // 
            this.XPointerBoardLocationStatusLabel.Name = "XPointerBoardLocationStatusLabel";
            this.XPointerBoardLocationStatusLabel.Size = new System.Drawing.Size(45, 17);
            this.XPointerBoardLocationStatusLabel.Text = "BoardX";
            // 
            // YPointerBoardLocationStatusLabel
            // 
            this.YPointerBoardLocationStatusLabel.Name = "YPointerBoardLocationStatusLabel";
            this.YPointerBoardLocationStatusLabel.Size = new System.Drawing.Size(45, 17);
            this.YPointerBoardLocationStatusLabel.Text = "BoardY";
            // 
            // board
            // 
            this.board.BackgroundImage = global::DarkChessClient.Properties.Resources.board;
            this.board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.board.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board.Cursor = System.Windows.Forms.Cursors.Default;
            this.board.Location = new System.Drawing.Point(0, 24);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(550, 550);
            this.board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.board.TabIndex = 2;
            this.board.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(557, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your turn!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(556, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "An enemy pawn has been promoted!";
            // 
            // DarkChessClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 603);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.board);
            this.Controls.Add(this.pointerBoardLocationStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "DarkChessClient";
            this.Text = "DarkChess client";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pointerBoardLocationStrip.ResumeLayout(false);
            this.pointerBoardLocationStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip pointerBoardLocationStrip;
        private System.Windows.Forms.ToolStripStatusLabel XPointerBoardLocationStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel YPointerBoardLocationStatusLabel;
        private System.Windows.Forms.PictureBox board;

        System.Drawing.Graphics gameBoardGraphics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


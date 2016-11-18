namespace DarkChessClient
{
    partial class PromotionDialog
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
            this.Knight = new System.Windows.Forms.Button();
            this.Bishop = new System.Windows.Forms.Button();
            this.Rook = new System.Windows.Forms.Button();
            this.Queen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Knight
            // 
            this.Knight.Location = new System.Drawing.Point(349, 12);
            this.Knight.Name = "Knight";
            this.Knight.Size = new System.Drawing.Size(75, 71);
            this.Knight.TabIndex = 0;
            this.Knight.Text = "button1";
            this.Knight.UseVisualStyleBackColor = true;
            // 
            // Bishop
            // 
            this.Bishop.Location = new System.Drawing.Point(238, 12);
            this.Bishop.Name = "Bishop";
            this.Bishop.Size = new System.Drawing.Size(74, 71);
            this.Bishop.TabIndex = 1;
            this.Bishop.Text = "button2";
            this.Bishop.UseVisualStyleBackColor = true;
            // 
            // Rook
            // 
            this.Rook.Location = new System.Drawing.Point(132, 12);
            this.Rook.Name = "Rook";
            this.Rook.Size = new System.Drawing.Size(78, 71);
            this.Rook.TabIndex = 2;
            this.Rook.Text = "button3";
            this.Rook.UseVisualStyleBackColor = true;
            this.Rook.Click += new System.EventHandler(this.button3_Click);
            // 
            // Queen
            // 
            this.Queen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Queen.Location = new System.Drawing.Point(25, 12);
            this.Queen.Name = "Queen";
            this.Queen.Size = new System.Drawing.Size(77, 71);
            this.Queen.TabIndex = 3;
            this.Queen.Text = "button4";
            this.Queen.UseVisualStyleBackColor = true;
            // 
            // PromotionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 110);
            this.ControlBox = false;
            this.Controls.Add(this.Queen);
            this.Controls.Add(this.Rook);
            this.Controls.Add(this.Bishop);
            this.Controls.Add(this.Knight);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PromotionDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PromotionDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Knight;
        private System.Windows.Forms.Button Bishop;
        private System.Windows.Forms.Button Rook;
        private System.Windows.Forms.Button Queen;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameNotations;

namespace DarkChessClient
{
    public partial class DarkChessClient : Form
    {
        public DarkChessClient()
        {
            InitializeComponent();
        }

        void board_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            XPointerBoardLocationStatusLabel.Text = $"{BoardGraphicsManager.SquareOfClick(me.Location).Item1}";
            YPointerBoardLocationStatusLabel.Text = $"{BoardGraphicsManager.SquareOfClick(me.Location).Item2}";
            BoardGraphicsManager.test(me.Location);
        }

        private void DarkChessClient_Load(object sender, EventArgs e)
        {
            BoardGraphicsManager.CreateGraphics(sender);
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            ConnectDialog cd = new ConnectDialog();
            cd.Show();
        }
    }
}

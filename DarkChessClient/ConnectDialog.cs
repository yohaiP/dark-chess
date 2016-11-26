using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkChessClient
{
    public partial class ConnectDialog : Form
    {
        public ConnectDialog()
        {
            InitializeComponent();
        }

        private void OnConnect(object sender, EventArgs e)
        {
            System.Net.IPAddress serverAddress = null;
            try
            {
                serverAddress = System.Net.IPAddress.Parse(ServerAddress.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("the IP Address you entered is spoiled");
            }
            NetworkManager.ConnectToGameServer(serverAddress, 1000);
            ((ConnectDialog)sender).Close();
        }
    }
}

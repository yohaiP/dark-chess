using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace DarkChessClient
{
    static class NetworkManager
    {
        static IPEndPoint serverEP;
        static Socket serverConnection;

        public static void ConnectToGameServer(IPAddress serverAddress, int serverPort)
        {
            try
            {
                serverConnection = new Socket(SocketType.Stream, ProtocolType.Tcp);
                serverEP = new IPEndPoint(serverAddress, serverPort);
                serverConnection.Connect(serverEP);
            }
            catch (SocketException)
            {
                System.Windows.Forms.MessageBox.Show("There is no listening server on the other side");
            }
        }
    }
}

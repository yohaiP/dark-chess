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

        static void ConnectToGameServer(IPAddress serverAddress, int serverPort)
        {
            serverConnection = new Socket(SocketType.Stream, ProtocolType.Tcp);
            serverEP = new IPEndPoint(serverAddress, serverPort);
            serverConnection.Connect(serverEP);
        }
    }
}

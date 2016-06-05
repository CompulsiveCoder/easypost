using System;
using System.Net.Sockets;
using System.Net;

namespace easypost.Tests
{
    static public class PortFinder
    {
        static public int GetFreeTcpPort()
        {
            TcpListener l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            return port;
        }
    }
}


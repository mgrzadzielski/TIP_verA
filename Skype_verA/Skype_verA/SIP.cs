using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace Skype_verA
{

    public class SIP
    {
        TcpListener tcp_listener = null;
        TcpClient tcp_listener_klient;
        TcpClient tcp_sender_klient;
        int sip_port = 5060; // unencrypted port (5061 - for encryption)
        byte[] bufor;
        IPAddress ip_lokalny;
        IPAddress ip_docelowy;


        public void SIP_gniazdo()
        {
            bufor = new byte[512];
            tcp_listener = new TcpListener(IPAddress.Any, sip_port);
            tcp_listener.Start();
            
        }





    }
}

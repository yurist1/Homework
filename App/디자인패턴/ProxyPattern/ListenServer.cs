using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class ListenServer //클라이언트 연결을 수락하는 서버
    {
        static public void StartListen(ICheese icheese) 
        {
            Socket sock = new Socket(AddressFamily.InterNetwork,
                                                  SocketType.Stream, ProtocolType.Tcp);
            sock.Bind(new IPEndPoint(IPAddress.Any, 10200));
            sock.Listen(5);
            while (true)
            {
                Stub stub = new Stub(sock.Accept(), icheese); //클라이언트와 통신을 담당
                Thread thread = new Thread(stub.Do);
                thread.Start();
            }
        }
    }
}

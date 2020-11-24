using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class RemoteController : ICheese
    {
        public void ChangeMilk(int milk)
        {
            Socket sock = Connect(MsgId.CHANGE);
            byte[] msg = new byte[1];
            msg[0] = Convert.ToByte(milk);
            sock.Send(msg);
            sock.Close();
        }

        public bool isSoldOut()
        {
            Socket sock = Connect(MsgId.SOLDOUT);
            byte[] buffer = new byte[1];
            int n = sock.Receive(buffer);
            return Convert.ToBoolean(buffer[0]);
        }

        public string MakeCheese()
        {
            Socket sock = Connect(MsgId.MAKE);
            byte[] buffer = new byte[256];
            int n = sock.Receive(buffer);
            sock.Close();
            return Encoding.UTF8.GetString(buffer, 0, n);

        }

        public void SellCheese(bool sell)
        {
            Socket sock = Connect(MsgId.SELL);
            byte[] msg = new byte[1];
            msg[0] = Convert.ToByte(sell);
            sock.Send(msg);
            sock.Close();
        }
        Socket Connect(MsgId msgid)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect("서버 IP 주소로 바꾸세요.", 10200);
            byte[] msg = new byte[1];
            msg[0] = (byte)msgid;
            sock.Send(msg);
            return sock;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{ 
    class Stub //클라이언트 명령을 받아 실제 개체를 제어하는 서버 측 클래스
    {
        Socket dosock; //클라이언트와 통신할 소켓
        ICheese icheese; //클라이언트의 요청에 맞게 기능을 수행할 실제 개체

        public Stub(Socket dosock, ICheese icheese)
        {
            this.dosock = dosock;
            this.icheese = icheese;
        }
        private void GetProc()
        {
            bool isSell = icheese.isSoldOut(); //실제 개체에게 모드를 얻어옴
            byte[] msg = new byte[1]; //모드를 전송할 때 필요한 버퍼
            msg[0] = Convert.ToByte(isSell);
            dosock.Send(msg);  //요청한 모드를 전송
        }
        private void TakeProc()
        {
            string makeCheese = icheese.MakeCheese(); //실제 개체로 사진을 찍음
            byte[] msg = Encoding.UTF8.GetBytes(makeCheese); //사진을 전송할 버퍼로 변환
            dosock.Send(msg); //실제 개체가 찍은 사진을 전송
        }
        private void ChangeProc()
        {
            byte[] buffer = new byte[1]; //모드를 수신할 때 필요한 버퍼
            int milk;
            dosock.Receive(buffer); //요청한 모드를 받음

            milk = Convert.ToInt32(buffer[0]);
            icheese.ChangeMilk(milk); //실제 개체에게 모드 변경 요청
        }

        public void Do()
        {
            byte[] buffer = new byte[1];
            int n = dosock.Receive(buffer); //명령 종류를 얻어옴

            MsgId msgid = (MsgId)buffer[0];
            Console.WriteLine(msgid);

            switch (msgid) //수신한 명령에 맞는 기능 수행
            {
                case MsgId.MAKE: TakeProc(); break;
                case MsgId.CHANGE: ChangeProc(); break;
                case MsgId.SELL: GetProc(); break;
                case MsgId.SOLDOUT: GetProc(); break;
            }
            dosock.Close();
        }
    }
}

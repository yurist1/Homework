using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //기본 프록시 패턴
            Image image = new ProxyImage("test.jpg");
            image.display();

            Console.WriteLine("==============================");
            
            //가상 프록시
            Farm camera = new Farm(); 

            //실제 개체를 제어를 요청할 클라이언트를 대기하는 서버 가동
            ListenServer.StartListen(camera);
        }
    }
}

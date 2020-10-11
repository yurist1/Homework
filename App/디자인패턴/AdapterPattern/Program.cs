using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICheckPatByA pat1 = new Patient1();
            Console.WriteLine("환자 1 정보");
            pat1.getHeight();
            pat1.getWeight();
            pat1.getPressure();

            Console.WriteLine("============");

            ICheckPatByB pat2 = new Patient2();
            Console.WriteLine("환자 2 정보");
            pat2.getHeight();
            pat2.getWeight();
            pat2.getPressure();
            pat2.getElectCardio();
            pat2.getBloodSugar();

            Console.WriteLine("============");
            //위의 처럼 할 경우 각 기계마다 모니터링할 비지니스 로직을 짜야한다. 
            //그래서 A를 B로 wrapping 해보자

            ICheckPatByB pat1_1 = new Adapter(new Patient1());
            Console.WriteLine("환자 1 정보");
            pat1_1.getHeight();
            pat1_1.getWeight();
            pat1_1.getPressure();
            pat1_1.getElectCardio();
            pat1_1.getBloodSugar();

            Console.ReadLine();

        }
    }
}

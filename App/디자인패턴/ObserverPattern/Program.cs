using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient("최유리", false, string.Empty);
            patient.View();
            IUpdate[] observers = new IUpdate[3];
            observers[0] = new PatFav(patient);
            observers[1] = new PatMemo(patient);
            patient.AddObserver(observers[0]);
            patient.AddObserver(observers[1]);
            patient.Change(true, "주의 바람");
            patient.Change(true, "=======\n변경된 메모->퇴원 요청");

            Console.Read();
        }
    }
}
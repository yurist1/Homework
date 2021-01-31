using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            Caaretaker careTaker = new Caaretaker();

            //상태 설정 및 복원 시점 추가
                     
            while (true) 
            {
                string content = Console.ReadLine();
                if (content.Length == 0)
                    break;
                originator.SetState(content);
                careTaker.add(originator.SaveStateMemento());

            }

            for (int i = 0; i < careTaker.GetLength(); i++)
            {
                originator.GetStateFromMemnto(careTaker.Get(i));
                Console.WriteLine($"Saved state {i}: {originator.GetState()}");
            }


            Console.ReadLine();
        }
    }
}

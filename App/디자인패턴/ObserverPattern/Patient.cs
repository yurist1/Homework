using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    class Patient : Subject
    {
    private string memo;
        public string Name
        {
            get;
            private set;
        }
        public bool Fav
        {
            get;
            private set;
        }
        public string Memo
        {
            get 
            {
                return memo;
            }
            private set 
            {
                memo = value;
                Notify();
            }
        }
     
        public Patient(string name, bool fav, string memo)
        {
            Name = name;
            Fav = fav;
            Memo = memo;
            
        }
        public void Change(bool fav, string memo)
        {
            Fav = fav;
            Memo = memo;
            Notify();
        }
        public void View()
        {
            Console.WriteLine("환자이름", Name);
            Console.WriteLine("관심환자:", Fav);
            Console.WriteLine("관심메모:", Memo);
        }
    }
}

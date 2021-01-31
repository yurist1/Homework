using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Caaretaker
    {
        private List<Memento> mementoList = new List<Memento>();
        public void add(Memento state) 
        {
            mementoList.Add(state);
        }
        public Memento Get(int index) 
        {
            return mementoList[index];
        }
        public int GetLength() 
        {
            return mementoList.Count();
        }
    }
}

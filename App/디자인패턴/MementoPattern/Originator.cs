using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Originator
    {
        private string state;

        public void SetState(string state) 
        {
            this.state = state;
        }
        public string GetState() 
        {
            return this.state;
        }
        public Memento SaveStateMemento() 
        {
            return new Memento(state);
        }
        public void GetStateFromMemnto(Memento memento) 
        {
            state = memento.GetState();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class _1914
    {
        int _parm;
        Stack<int> stack1;
        Stack<int> stack2 ;
        Stack<int> stack3 ;
        int countMovement;
        public _1914(object parm) 
        {
            _parm = (int)parm;
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
            stack3 = new Stack<int>();
            countMovement = 0;

            for (int item = _parm; item > 0; item--)
            {
                stack1.Push(item);
            }
        }
        public void Solve() 
        {
            while (stack1.Count()>0) 
            {
                int item = stack1.Peek();
                MoveItem(item, 1);
            }
          
        }
        private void MoveItem(int item, int from) 
        {
            if (stack1.Count() == 0 || stack1.Peek() > item) 
            {
            
            }
            else if (stack2.Count() == 0 || stack2.Peek() > item)
            {

            }
            else if (stack3.Count() == 0 || stack3.Peek() > item)
            {

            } else 
            {
            

            }
        }
    }
}

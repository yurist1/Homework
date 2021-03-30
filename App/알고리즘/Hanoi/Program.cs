using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        private static Stack<int> stack1 = new Stack<int>();
        private static Stack<int> stack2 = new Stack<int>();
        private static Stack<int> stack3 = new Stack<int>();
        static void Main(string[] args)
        {


            int num = int.Parse(args[0]);
            //for (int item = num; item > 0; item--)
            //{
            //    stack1.Push(item);
            //}

            //MoveItem(1, 3);

            double count = 1;
            count = num == 1 ? 1 : Math.Pow(2, num) - 1;
            Console.WriteLine($"result => {count}");

            if (num <= 20)
            {
                process(num, 1, 3, 2);
            }


            Console.ReadLine();

        }

        private static void process(int plates, int from, int to, int mid)
        {
            if (plates == 1)
            {
                Console.WriteLine($"{from}에서 {to}로 이동");
            }
            else
            {
                // a(n-1)을 mid로 보내는 일반식
                process(plates - 1, from, mid, to);
                Console.WriteLine($"{from}에서 {to}로 이동");
                //a(n-1)을 다시 목적지로 보내는 일반식
                process(plates-1, mid, to, from);
            }

        }
        private static void MoveItem(int from, int to)
        {
            int item_from = 0;
            int item_to = 0;
            switch (from)
            {
                case 1:
                    if (stack1.Count() > 0)
                        item_from = stack1.Pop();
                    else
                        MoveItem(3, to);
                    break;
                case 2:
                    if (stack1.Count() > 0)
                        item_from = stack2.Pop();
                    else
                        MoveItem(1, to);
                    break;
                default:
                    if (stack1.Count() > 0)
                        item_from = stack3.Pop();
                    else
                        MoveItem(2, to);
                    break;
            }

            switch (to)
            {
                case 1:
                    if (stack1.Count() > 0)
                        item_to = stack1.Peek();
                    else
                        item_to = 0;
                    break;
                case 2:
                    if (stack2.Count() > 0)
                        item_to = stack2.Peek();
                    else
                        item_to = 0;
                    break;
                default:
                    if (stack3.Count() > 0)
                        item_to = stack3.Peek();
                    else
                        item_to = 0;
                    break;
            }

            if (item_from < item_to)
            {
                //쌓고 
                switch (to)
                {
                    case 1:
                        stack1.Push(item_from);
                        break;
                    case 2:
                        stack2.Push(item_from);
                        break;
                    default:
                        stack3.Push(item_from);
                        break;
                }

            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1_GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //long mem1 = GC.GetTotalMemory(false);
            //{
            //    // Allocate an array and make it unreachable.
            //    int[] values = new int[5];
            //    values = null;
            //}
            //long mem2 = GC.GetTotalMemory(false);
            //{
            //    // Collect garbage.
            //    GC.Collect();
            //}
            //long mem3 = GC.GetTotalMemory(false);
            //{
            //    Console.WriteLine(mem1);
            //    Console.WriteLine(mem2);
            //    Console.WriteLine(mem3);

            //}



            long mem = GC.GetTotalMemory(true);
            {
                Parallel.For(0, 1000, i =>
                {
                    int[] values = new int[5];
                    values = null;
                    //GC.Collect();
                    Console.WriteLine($"{i}회 => {GC.GetTotalMemory(false)} / {GC.GetTotalMemory(true)} / {GC.CollectionCount(i)}");

                    //values.Count();
                    //Console.WriteLine($"{i}회 => {GC.GetTotalMemory(false)} / {GC.GetTotalMemory(true)} / {mem}");
                });
                Console.Read();

            }
        }
    }
}

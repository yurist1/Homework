using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Brandi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var input = args.First().Split(new string[] { "\r\n" }, StringSplitOptions.None);
            var age = input.First();
            var simbac = input.Skip(1);
            var result = new Dictionary<int, int>();

            var max = 220 - int.Parse(age);

            foreach (var item in simbac)
            {
                var itemNum = int.Parse(item);
                var tempStatus = 0;
                if (max * 0.6 > itemNum)
                {
                    //휴식
                    tempStatus = 0;
                }
                else if (max * 0.68 > itemNum) 
                {
                    //워밍업
                    tempStatus = 1;
                }
                else if (max * 0.75 > itemNum)
                {
                    //집주훈련
                    tempStatus = 2;
                }
                else if (max * 0.80 > itemNum)
                {
                    //중강도
                    tempStatus = 3;
                }
                else if (max * 0.9 > itemNum)
                {
                    //고강도
                    tempStatus = 4;
                }
                else if (max * 0.9 <= itemNum)
                {
                    //최고강도
                    tempStatus = 5;
                }

                if (result.Count() == 0)
                {
                    result.Add(tempStatus, 1);
                }
                else if (result.Keys.Last() == tempStatus)
                {
                    result[tempStatus]++;
                }
                else 
                {
                    result.Add(tempStatus, 1);
                }
            }

            //foreach (var item in result)
            //{
            //    Console.Write($"{item.Value} ");
            //}

            for (int i = result.Count(); i > 0; i--)
            {
                var keys = result.Keys.ToList();
                Console.Write($"{result[keys[i-1]]} ");
            }
            Console.ReadLine();   
        }
    }
}

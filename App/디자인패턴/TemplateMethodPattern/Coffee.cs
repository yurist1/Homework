using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    abstract class Coffee
    {
        public void MakeCoffee() 
        {
            Console.WriteLine("커피 제조 시작!!");
            Console.WriteLine($"샷 {Shot()}잔 넣고");
            Console.WriteLine(Milk() == null? "우유 안넣고" : $"{Milk()} 넣고");
            Console.WriteLine(Water() > 0 ? $"물 {Water()}ml 넣고": "물 안넣고 ");
            Console.WriteLine("커피 제조 완료!!!");
        }
        protected virtual int Shot() 
        {
            return 2;
        }
        protected abstract string Milk();
        protected virtual int Water() 
        {
            return 100;
        }
    }
}

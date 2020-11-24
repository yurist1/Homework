using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Farm : ICheese
    {
        bool _isSoldOut = false; 
        public void ChangeMilk(int milk)
        {
            switch (milk) 
            {
                case 1:
                    Console.WriteLine("젖소 우유");
                    break;
                case 2:
                    Console.WriteLine("거위 우유");
                    break;
                default:
                    Console.WriteLine("양 우유");
                    break;
            }
        }

        public bool isSoldOut()
        {
            if (_isSoldOut)
            {
                Console.WriteLine("판매 실적이 있습니다.");
            }
            else
            {
                Console.WriteLine("새상품 입니다.");
            }
            return _isSoldOut;
        }

        public string MakeCheese()
        {
            Console.WriteLine("치즈를 만든다.");
            if (_isSoldOut)
            {
                return "인기 상품 치즈";
            }
            return "신제품 치즈";
        }

        public void SellCheese(bool sell)
        {
            _isSoldOut = sell;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
   public interface ICheese
    {
        string MakeCheese();
        void ChangeMilk(int milk);
        void SellCheese(bool sell);
        bool isSoldOut();
    }
    enum MsgId 
    {
        MAKE = 1,
        CHANGE,
        SELL,
        SOLDOUT
    }
    enum Milk 
    {
        Cow =1,
        Goose,
        Lamb
    }
}

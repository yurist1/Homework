using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2_Overload
{
    class Operation
    {
        public int a = 0;
        public Operation(int a)
        {
            this.a = a;
        }
        public static Operation operator ++(Operation a1)
        {
            return new Operation(a1.a + 2);
        }


        public static int operator +(Operation a1, Operation b1)
        {
            return a1.a - b1.a;
        }
        public static int operator -(Operation a1, Operation b1)
        {
            return a1.a + b1.a;
        }

        //public static Operation operator + (Operation a1, Operation b1)
        //{
        //    return new Operation(a1.a - b1.a);
        //}
        //public static Operation operator - (Operation a1, Operation b1)
        //{
        //    return new Operation(a1.a + b1.a);
        //}

        //public static Operation operator += (Operation a1,Operation b1)
        //{
        //    Operation result = new Operation(a1.a + b1.a);
        //    return result;
        //}

        public static bool operator >(Operation a1, Operation b1)
        {
            if (a1.a > b1.a)
                return true;
            else
                return false;
        }
        public static bool operator <(Operation a1, Operation b1)
        {
            return !(a1.a > b1.a);
        }

    }
}

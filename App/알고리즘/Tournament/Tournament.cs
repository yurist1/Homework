using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament
{
    public class Tournament
    {
        public Tournament() 
        {
        
        }
        public int solution(int n, int a, int b)
        {
            int answer = DoGame(0, n, a, b);



            return answer;
        }
        private int DoGame(int gameInd, int players, int A, int B)
        {
            if (players == 2 || (Math.Abs(A - B) == 1 && Math.Max(A, B) % 2 == 0))
            {
                return ++gameInd;
            }
            else
            {
                var result = new int[players / 2];
                int ind = 1;
                int A1 = 0;
                int B1 = 0;
                while (ind <= players)
                {
                    if (result[(ind - 1) / 2] == 0 || ind == A || ind == B)
                    {
                        result[(ind - 1) / 2] = ind;
                        if (ind == A)
                            A1 = ((ind - 1) / 2) + 1;
                        else if (ind == B)
                            B1 = ((ind - 1) / 2) + 1;
                    }
                    ind++;
                }
                return DoGame(++gameInd, result.Length, A1, B1);
            }
        }
    }
}

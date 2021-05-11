using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tournament
{
    public class WordPuzzle
    {
        private string[] puzzles;
        private List<int> indexs;
        public WordPuzzle() 
        {
        
        }
        public int solution(string[] strs, string t)
        {
            puzzles = strs;
            int ind = 0;

            indexs = new List<int>();
            var test = MatchPuzzle(t, ind);
             return indexs.Count() == 0 ? -1: indexs.Min();
        }

        public int MatchPuzzle(string target, int ind) 
        {
                bool isMatched = false;
                foreach (var puzzle in puzzles) 
                {
                    if (Regex.IsMatch(target, "[a-zA-Z]"))
                    {
                        if (target.Contains(puzzle))
                        {
                            var regex = new Regex(Regex.Escape(puzzle));

                            isMatched = MatchPuzzle(regex.Replace(target, " ", 1), ind+1) == -1 ? false: true;
                        }
                    }
                    else 
                    {
                        indexs.Add(ind);
                        break;
                    }
                       
                }

                if (!isMatched)
                    return -1;
            

            return ind;
        }
        
    }
}

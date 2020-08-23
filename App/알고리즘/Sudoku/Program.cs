using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        private static string[] quiz;
        private static int[,] quizMatrix;
        private static List<EmptyIndex> countEmpty;
        static void Main(string[] args)
        {
            quiz = args;


            //배열화 하기
            init();
            //풀기
            while (countEmpty.Count() > 0)
            {

                foreach (var item in countEmpty)
                {
                    var row = item.rowInd;
                    var col = item.colInd;

                    // 세로
                    int[] vertlink = getVerticalLine(col);
                    if (vertlink.Where(d => d.Equals(0)).Count() == 1)
                    {
                        int result = solve(vertlink);
                        quizMatrix.SetValue(result, row, col);
                        countEmpty.Remove(item);
                        break;
                    }
                    //가로
                    int[] horlink = getHorizonLine(row);
                    if (horlink.Where(d => d.Equals(0)).Count() == 1)
                    {
                        int result = solve(horlink);
                        quizMatrix.SetValue(result, row, col);
                        countEmpty.Remove(item);
                        break;
                    }
                    //사각형
                    int[] sqrlink = getSquare(row, col);
                    if (sqrlink.Where(d => d.Equals(0)).Count() == 1)
                    {
                        int result = solve(sqrlink);
                        quizMatrix.SetValue(result, row, col);
                        countEmpty.Remove(item);
                        break;
                    }

                }
            }

            Console.WriteLine("finish");
            for (int resultRow = 0; resultRow < 9; resultRow++)
            {
                for (int resultCol = 0; resultCol < 9; resultCol++)
                {
                    Console.Write($"{quizMatrix[resultRow, resultCol]} ");
                }
                Console.Write("\r\n");
            }

            Console.ReadKey();
        }

        private static void init()
        {
            countEmpty = new List<EmptyIndex>();
            quizMatrix = new int[9, 9];
            for (int i = 0; i < quiz.Length; i++)
            {
                quizMatrix.SetValue(int.Parse(quiz[i].Replace("\r\n", "")), i / 9, i % 9);
                if (quizMatrix[i / 9, i % 9] == 0) 
                {
                    countEmpty.Add(new EmptyIndex(i / 9, i % 9));
                }
            }
        }

        private static int[] getVerticalLine(int col)
        {
            var verticalLink = new int[9];
            for (int i = 0; i < verticalLink.Length; i++)
            {
                verticalLink.SetValue(quizMatrix[i, col], i);
            }

            return verticalLink;

        }
        private static int[] getHorizonLine(int row)
        {
            var horizonLink = new int[9];
            for (int i = 0; i < horizonLink.Length; i++)
            {
                horizonLink.SetValue(quizMatrix[row, i], i);
            }

            return horizonLink;

        }
        private static int[] getSquare(int row, int col)
        {
            var squareLink = new int[9];
            int i = 0;
            for (int sqrRow = (row / 3) * 3; sqrRow < (row / 3) * 3 + 3; sqrRow++)
            {
                for (int sqrCol = (col / 3) * 3; sqrCol < (col / 3) * 3 + 3; sqrCol++)
                {
                    squareLink.SetValue(quizMatrix[sqrRow, sqrCol], i++);
                }
            }



            return squareLink;

        }
        private static int solve(int[] line)
        {
            int result = 45 - line.Sum();
            return result;

        }
    }

    class EmptyIndex 
    {
        public EmptyIndex(int row, int col) 
        {
            rowInd = row;
            colInd = col;
        }
        public int rowInd { get; set; }
        public int colInd { get; set; }
    }
}

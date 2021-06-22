using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_2_loops_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Print Avg

            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    sum += int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Avg: {0}", sum/5);

            #endregion

            #region 0-9 , 0-8, 0-7...

            //for (int i = 10; i > 0; i--)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Multiplication Table

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
            //i = 2; j = 2;
            //1   2   3   4    5...10  
            //2   4   6   8    10..20
            //3   6   9   12.......30
            #endregion

            #region School Pupils

            int numOfPupils = int.Parse(Console.ReadLine());
            int classesCounter = 0;

            //while(numOfPupils / 10 > 0)
            //{
            //    classesCounter++;
            //    if (numOfPupils >= 100)
            //    {
            //        numOfPupils -= 100;
            //    }
            //    else if (numOfPupils >= 30)
            //    {
            //        numOfPupils -= 30;
            //    }
            //    else
            //        numOfPupils -= 10;
            //}
            for (int i = 0; i <= numOfPupils / 100; i++)
            {
                classesCounter++;
                numOfPupils -= 100;
            }
            for (int i = 0; i <= numOfPupils / 30; i++)
            {
                classesCounter++;
                numOfPupils -= 30;
            }
            for (int i = 0; i <= numOfPupils / 10; i++)
            {
                classesCounter++;
                numOfPupils -= 10;
            }
            Console.WriteLine("Classes Needed: {0}", classesCounter);
            Console.WriteLine("Without Class: {0}", numOfPupils);

            #endregion

            #region ETGAR: Print Vertical Triangle
            int num = int.Parse(Console.ReadLine());

            int spaces = num / 2;
            int printSymbols = num - (spaces*2);
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y < printSymbols; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                spaces--;
                printSymbols += 2;
                if (spaces < 0)
                    break;
            }
            #endregion
        }
    }
}

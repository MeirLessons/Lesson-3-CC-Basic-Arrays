using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());    
            int.Parse(Console.ReadLine());
            Console.WriteLine(@"Please Enter First\Last Name");
            int[] arrrr = new int[2] { 3, 5 };
            int myint = 24;
            int myint2 = 30;
            int myint3 = 40;
            //Console.WriteLine("Value 1 Is: {0}. Value 2 Is: {1}. Value 3 Is: {2}",myint,myint2,myint3);
            Console.WriteLine($"Value 1 Is: \"{arrrr[0]}.\"\n Value 2 Is: \"{myint2}\".\n Value 3 Is: \"{myint3}\"\t end");


            string defaultStrValue = null;
            int defaultNumberValue = 0;
            bool defaultBoolValue = false;
            char defaultCharValue = '0';

            //***************************************************

            //1:
            //מגדיר גודל של מערך בלי ערכים לאיברים(כל האיברים יקבלו דיפולט)
            bool[] myArr = new bool[5];
            myArr[0] = true;
            myArr[3] = true;
            Console.WriteLine(myArr.Length);

            //2:
            //הגדרה של מערך עם נתינת ערכים ישר ביצירה (גודל המערך ייקבע לפי כמות הערכים שאתן)
            string[] myStrArr = {"1","Moshe","","Hackeru"};
                               //[0]  [1]    [2]   [3] 
            myStrArr[0] = "new 1";

            //3:
            // כול את שיטה 1 ושיטה 2 ביחד - מונע בלבולים
            int[] grades = new int[3] { 100,90,85 };

            //4:
            // הגדרת מערך ללא התחייבות לגודל וללא נתינת ערכים
            char[] myChars;
            int size = int.Parse(Console.ReadLine());//36
            myChars = new char[size];// יוצר את המערך
            myChars[0] = 'f';
            
        }
    }
}

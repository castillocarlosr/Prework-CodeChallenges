using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class Program
    { 
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Code Challenges Program.  Choose a number problem.........");
            Console.WriteLine("1) Problem 1:Array Max Result");
            Console.WriteLine("2) Problem 2: Leap Year Calculator");
            Console.WriteLine("3) Problem 3: Perfect Sequence");
            Console.WriteLine("4) Problem 4: Sum of Rows");
            Console.WriteLine("5) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                ArrayMaxResult();
                return true;
            }
            else if (result == "2")
            {
                LeapYearCalculator();
                return true;
            }
            else if (result == "3")
            {
                PerfectSequence();
                return true;
            }
            else if (result == "4")
            {
                SumofRows();
                return true;
            }
            else if((result == "5") || (Console.ReadKey().Key == ConsoleKey.Escape))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void ArrayMaxResult()
        {
            //Write in some code block here -love carlos
            Console.WriteLine("Test code 1.  Yup, this is only a test");
            Console.ReadLine();
        }

        private static void LeapYearCalculator()
        {
            //Write in some code block here -love carlos
            Console.WriteLine("Test code 2.  Yup, this is only a test");
            Console.ReadLine();
        }

        private static void PerfectSequence()
        {
            //Write in some code block here -love carlos
            Console.WriteLine("Test code 3.  Yup, this is only a test");
            Console.ReadLine();
        }

        private static void SumofRows()
        {
            //Write in some code block here -love carlos
            Console.WriteLine("Test code 4.  Yup, this is only a test");
            Console.ReadLine();
        }


    }
}

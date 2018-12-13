using System;
using System.Collections;
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
            Console.WriteLine("Code Challenges Program.  Choose a number problem.");
            Console.WriteLine("   ");
            Console.WriteLine("1) Problem 1: Array Max Result");
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
            //else if((result == "5") || (Console.ReadKey().Key == ConsoleKey.Escape))
            else if (result == "5")
            {
                return false;
            }
            else
            {
                OtherKeyPressed();
                return true;
            }
        }

        private static void ArrayMaxResult()
        {
            Console.Clear();
            Console.WriteLine("Problem 1: Array Max Result");
            Console.WriteLine("Choose 5 numbers between 1-10");
            //ArrayList userList = new ArrayList();
            List<int> userList = new List<int>();
            //int[]userList = new int[5];

            Console.WriteLine("   ");
            Console.Write("Choose the first number:  ");
            string result = Console.ReadLine();
            userList.Add(int.Parse(result));
            Console.Write("Choose the second number: ");
            string result2 = Console.ReadLine();
            userList.Add(int.Parse(result2));
            Console.Write("Choose the third number:  ");
            string result3 = Console.ReadLine();
            userList.Add(int.Parse(result3));
            Console.Write("Choose the forth number:  ");
            string result4 = Console.ReadLine();
            userList.Add(int.Parse(result4));
            Console.Write("Choose the fifth number:  ");
            string result5 = Console.ReadLine();
            userList.Add(int.Parse(result5));
            
            Console.Write($"Choose number from the list: [{userList[0]}, {userList[1]}, {userList[2]}, {userList[3]}, {userList[4]}]:  ");
            string score = Console.ReadLine();
            
            int i = 0;
            int frequency = 0;
            for(i = 0; i<userList.Count; i++)
            {
                if (int.Parse(score) == userList[i])
                    ++frequency;
            }
            int solution1 = frequency * int.Parse(score);
            Console.WriteLine($"Score:  {solution1}");
            Console.ReadLine();
            /* Problem 1 works.  Code block finished on Dec. 10 by Carlos Castillo */
        }

        private static void LeapYearCalculator()
        {
            Console.Clear();
            Console.WriteLine("Problem 2: Leap Year Calculator.");
            Console.WriteLine(" ");
            Console.Write("Choose a year:  ");
            int userYear = int.Parse(Console.ReadLine());

            if ((userYear % 400) == 0)
            {
                Console.WriteLine($"The year {userYear} is a leap year!");
            }
            else if ((userYear % 100) == 0)
            {
                Console.WriteLine($"The year {userYear} is NOT a leap year.");
            }
            else if ((userYear % 4) == 0)
            {
                Console.WriteLine($"The year {userYear} is a leap year!");
            }
            else
                Console.WriteLine($"The year {userYear} is NOT a leap year.");
            Console.ReadLine();
            /* Problem 2 works.  Code block finished on Dec. 11 by Carlos Castillo */
        }
        
        private static void PerfectSequence()
        {
            //Write in some code block here -love carlos
            Console.Clear();
            Console.WriteLine("Problem 3: Perfect Sequence.");
            Console.WriteLine(" ");
            //List<int> userSequence = new List<int>();

            Console.Write("Choose 2 to 10 numbers seperated by a space or comma:  ");
            //string result5 = Console.ReadLine();
            //userList.Add(int.Parse(result5));
            //int userSequence = int.Parse(Console.ReadLine());
        }
        
        private static void SumofRows()
        {
            //Write in some code block here -love carlos
            Console.Clear();
            Console.WriteLine("Test code 4.  Yup, this is only a test");
            Console.ReadLine();
        }

        private static void OtherKeyPressed()
        {
            Console.Clear();
            Console.WriteLine("Oh no.....Looks like you didn't type 1, 2, 3, 4, or 5.");
            Console.ReadLine();
        }


    }
}

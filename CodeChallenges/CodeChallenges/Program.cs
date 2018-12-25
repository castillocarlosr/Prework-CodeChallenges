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
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Code Challenges Program.  Choose a number problem.");
            Console.WriteLine(" ");
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
            int[]userList = new int[5];

            #region Choosing 5 numbers
            Console.WriteLine("   ");
            Console.Write("Choose the first number:  ");
            userList[0] = int.Parse(Console.ReadLine());
            Console.Write("Choose the second number: ");
            userList[1] = int.Parse(Console.ReadLine());
            Console.Write("Choose the third number:  ");
            userList[2] = int.Parse(Console.ReadLine());
            Console.Write("Choose the forth number:  ");
            userList[3] = int.Parse(Console.ReadLine());
            Console.Write("Choose the fifth number:  ");
            userList[4] = int.Parse(Console.ReadLine());
            #endregion

            Console.Write($"Choose number from the list: [{userList[0]}, {userList[1]}, {userList[2]}, {userList[3]}, {userList[4]}]:  ");
            string score = Console.ReadLine();
            
            int i = 0;
            int frequency = 0;
            for(i = 0; i<userList.Length; i++)
            {
                if (int.Parse(score) == userList[i])
                    ++frequency;
            }
            int solution1 = frequency * int.Parse(score);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Score:  {solution1}");
            Console.ReadLine();
            /* Problem 1 works.  Code block finished on Dec. 10 by Carlos Castillo */
        }

        private static void LeapYearCalculator()
        {
            Console.Clear();
            Console.ResetColor();
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
            Console.Clear();
            Console.WriteLine("Problem 3: Perfect Sequence.");
            List<int> userSequence = new List<int>();

            Console.WriteLine(" ");
            Console.Write("Enter the first interger: ");
            string input = Console.ReadLine();
            //while (input != "")
            while (!string.IsNullOrEmpty(input))
            {
                userSequence.Add(int.Parse(input));
                Console.Write("Please enter another integer or press ENTER when done:  ");
                input = Console.ReadLine();
            }
            //if (input == "")
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("");
                Console.WriteLine("The numbers you entered are: [" + string.Join(", ", userSequence) + "]");
                int product = 1;
                int sum = 0;
                for (int j =0; j<userSequence.Count; j++)
                {
                    product *= userSequence[j];
                    sum += userSequence[j];

                }
                    if(sum == product)
                    {
                        Console.WriteLine("YES.  Perfect sequence.");
                    }
                    else
                    {
                        Console.WriteLine("NO.  Not a perfect sequence.");
                    }
                Console.ReadLine();
            }
            /* Problem 3 works.  Code block finished on Dec. 13 by Carlos Castillo */
        }

        private static void SumofRows()
        {
            Console.Clear();
            Console.WriteLine("Problem 4:  Sum of Rows.");
            Console.WriteLine("");
            Console.Write("Enter the number of ROWS you want:  ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of COLUMNS you want:  ");
            int columns = int.Parse(Console.ReadLine());

            /*test array below
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            */
            int[,] myArray = new int[rows, columns];
            Random rnd = new Random();
            for (int k = 0; k< myArray.GetLength(0); k++)
            {
                for(int l = 0; l< myArray.GetLength(1); l++)
                {
                    myArray[k,l] = rnd.Next(-99, 99);
                }
            }

            //This is the math addition for the rows.  Display code at the bottom.
            int[] rowSum = new int[myArray.GetLength(0)];
            for (int m=0; m< myArray.GetLength(0); m++)
            {
                rowSum[m] = 0;
                for(int n = 0; n< myArray.GetLength(1); n++)
                {
                    rowSum[m] += myArray[m, n];
                }
            }
            //Display the random generated array
            Console.WriteLine($"The random generated integers in the array are as follows:");
            for (int o = 0; o< myArray.GetLength(0); o++)
            {
                Console.Write("[ ");
                for (int p = 0; p< myArray.GetLength(1); p++)
                {
                    //Console.Write($"{myArray[o, p]} ");
                    //string str = (Convert.ToString(myArray[o,p]) + ", ");
                    Console.Write(myArray[o, p] + " ");
                    
                    //Console.Write(str.Replace(" ", ","));

                /* I want to not have the last comma show up when myAraay[o,p] + "," is displayed in console
                  I dont know how to go about this.  Will look into this*/
                }
                Console.Write("]");
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine(" ");
            //Display the result for the math addition above
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The sum is: [{string.Join(", ", rowSum)}]");
            Console.ReadLine();
            /* Problem 4 works.  Code block finished on Dec. 19 by Carlos Castillo */
        }

        private static void OtherKeyPressed()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Oh no.....Looks like you didn't type 1, 2, 3, 4, or 5.");
            Console.ReadLine();
        }


    }
}

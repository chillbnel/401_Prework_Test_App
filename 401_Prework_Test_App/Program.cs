using System;

namespace _401_Prework_Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int leapYear = 1996;
            int notLeapYear = 1900;
            int[] notPerfectArray = {4, 5, 6};
            int[] perfectArray = { 1,3,2 };
            int[,] sumArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };

            Score(); //Code Challenge 1, Problem 1

            LeapYear(leapYear); //Code Challenge 1, Problem 2
            LeapYear(notLeapYear); //Code Challenge 1, Problem 2

            PerfectSequence(perfectArray); //Code Challenge 1, Problem 3
            PerfectSequence(notPerfectArray); //Code Challenge 1, Problem 3

            SumRows(sumArray);//Code Challenge 1, Problem 4
        }

//Code Challenge 1, Problem 1: Array Max Results
        static void Score()
        {
            int[] selectedArray = new int[5];
            int counter = 0;
            int selectedNumber = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a number between 1-10:");
                selectedArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please select any number you entered above:");
            selectedNumber = int.Parse(Console.ReadLine());

            foreach (int item in selectedArray)
            {
                if (item == selectedNumber)
                {
                    counter = counter + 1;
                }
            }
            Console.WriteLine("Your score is: " + selectedNumber * counter);
        }

 //Code Challenge 1, Problem 2: Leap Year Calculator
        static void LeapYear(int userYear)
        {
            if (userYear % 4 == 0)
            {
                if (userYear % 100 == 0)
                {
                    if (userYear % 400 == 0)
                    {
                        Console.WriteLine("It's a leap year! :)");
                    }
                    else
                    {
                        Console.WriteLine("It's not a leap year! :(");
                    }
                }
                else
                {
                    Console.WriteLine("It's a leap year! :)");
                }
            } else
            {
                Console.WriteLine("It's not a leap year! :(");
            }
        }

//Code Challenge 1, Problem 3: Perfect Sequence
        static string PerfectSequence(int[] array)
        {
            int multiply = 1;
            int add = 0;
            string isPerfect = "Yes";
            string isNotPerfect = "No";

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] >= 0)
                {
                    add = add + array[i];
                    multiply = multiply * array[i];
                }
                else
                {
                    multiply = 1;
                    add = 0;
                    Console.WriteLine("Contains a negative number");
                    break;
                }
            }

            if(multiply == add)
            {
                Console.WriteLine("A perfect number!");
                return isPerfect;
            }
            else
            {
                Console.WriteLine("NOT a perfect number!");
                return isNotPerfect;
            }
        }

//Code Challenge 1, Problem 4: Sum of Rows       
        static int[] SumRows(int[,] array)
        {
            int[] sumArray = new int[array.GetLength(0)];

            for(int i = 0; i < array.GetLength(0); i++)
            {
                int total = 0;

                for(int j = 0; j < array.GetLength(1); i++)
                {
                    sumArray[i] = total + array[i, j];
                }
            }
            return sumArray;
        }
    }
}
using System.Drawing;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a day number (1–7).");
            int dayNumber;

            while (true)
            {
                bool isDayOfWeak = int.TryParse(Console.ReadLine(), out dayNumber);
                if (isDayOfWeak && (dayNumber >= 1 && dayNumber <= 7))
                {

                    DayOfWeek day = (DayOfWeek)dayNumber;

                    Console.WriteLine($"The day of the week is: {day}");

                    string dayStatus = day switch
                    {
                        DayOfWeek.Saturday or DayOfWeek.Friday => "Weekend",
                        _ => "Workday"
                    };
                    Console.WriteLine($"The day is a: {dayStatus}");
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                }









            }


            Console.WriteLine("Enter array size :");
            int[]? array = new int[int.Parse(Console.ReadLine()!)];
          

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter element {i}:");
                bool isElement = int.TryParse(Console.ReadLine(), out array[i]);
                if (!isElement)
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    i--; //
                }
         
            
                 } 

            int sum = 0;
                foreach (int item in array)
                {
                    sum += item;
                    

                }
            int max = array[0];
            int min = array[0];


            for (int i = 0;i < array.Length; i++)
            {
                
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }


            }
     
            Console.WriteLine($"Sum={sum}");

            double agerage = (double)sum / array.Length;

            Console.WriteLine($"Agerage={agerage}");

            Console.WriteLine($"min{min}");

            Console.WriteLine($"max={max}");
            Console.WriteLine("\nArray in reverse order:");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }


            Console.WriteLine("==================");


            int students = 3;
            int subjects = 4;
            double[,] grades = new double[students, subjects];

           
            for (int i = 0; i < students; i++)
            {
                Console.WriteLine($"\nEnter grades for student {i + 1}:");
                for (int j = 0; j < subjects; j++)
                {
                    bool validInput = false;
                    while (!validInput)
                    {
                        Console.Write($"Grade for subject {j + 1}: ");
                        validInput = double.TryParse(Console.ReadLine(), out grades[i, j]);
                        if (!validInput)
                        {
                            Console.WriteLine("Invalid input! Please enter a number.");
                        }
                    }
                }
            }

            double totalSum = 0;
            Console.WriteLine("\nStudent averages:");
            for (int i = 0; i < students; i++)
            {
                double summ = 0;
                for (int j = 0; j < subjects; j++)
                {
                    summ += grades[i, j];
                }
                double average = summ / subjects;
                totalSum += summ; 
                Console.WriteLine($"Student {i + 1} average: {average:F2}");
            }

            double classAverage = totalSum / (students * subjects);
            Console.WriteLine($"\nClass average: {classAverage:F2}");



            Console.WriteLine("==================");


            Console.WriteLine("Enter first number:");
            bool isFirstNumber = double.TryParse(Console.ReadLine(), out double firstNumber);
            if (!isFirstNumber)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                return;
            }

            Console.WriteLine("Enter second number:");
            bool isSecondNumber = double.TryParse(Console.ReadLine(), out double secondNumber);
            if (!isSecondNumber)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                return;
            }

            Console.WriteLine("select the type of operation : (+, -, *, /)");
            char operation = Console.ReadLine()![0];
           
            switch (operation)
            {
                case '+': 
                Console.WriteLine($"Result: {Add(firstNumber, secondNumber)}");
                    break;
                case '-':
             Console.WriteLine($"Result:{Subtract(firstNumber, secondNumber)}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {Multiply(firstNumber, secondNumber)}");
                    break;
                case '/':
                    Console.WriteLine($"Result: {Divide(firstNumber, secondNumber)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation! Please select one of the following: +, -, *, /");
                    break;
            }












        }


        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN;
            }
            return a / b;
        }






    }
}
    

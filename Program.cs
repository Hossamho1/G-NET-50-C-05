namespace ConsoleApp5

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[5];
          
            for (int i=0; i<array.Length; i++)
            {
                Console.WriteLine($"Enter score for student {i+1}:  ");
                bool isScore = int.TryParse(Console.ReadLine(), out array[i]);
                if (!isScore)
                {
                    Console.WriteLine(" Number is Invalid ");
                    i--;

                }
            }

            GetMinMax(array, out int max, out int min);
            Console.WriteLine($"The maximum score is: {max}");
            Console.WriteLine($"The minimum score is: {min}");
            CalculateAverage(array);
            Console.WriteLine($"The average score is: {CalculateAverage(array)}");
            
            for(var i=0; i < array.Length; i++)
            {
                Console.WriteLine($"the Grade of Student {i}= {GetGrade(array[i])}") ;
            }


        }

        static void GetMinMax(int[] score ,out int max ,out int min)
        {
            max=score[0];
            min = score[0];
            
            for(int i = 1; i < score.Length; i++)
            {
                if (score[i] > max)
                {
                    max = score[i];
                }
                if (score[i] < min)
                {
                    min = score[i];
                }   
                
           
            }
            
        }


       static double CalculateAverage(int[] score)
        {
            int sum = 0; 
            foreach (int item in score)
            {
                sum += item;

            }
            return (double)sum / score.Length;
        }

        static Grade GetGrade(int score) { 
        if(score >=90)
            {
                return Grade.A;
            }
            else if (score >= 80)
            {
                return Grade.B;
            }
            else if (score >= 70)
            {
                return Grade.C;
            }
            else if (score >= 60)
            {
                return Grade.D;
            }
            else
            {
                return Grade.F;
            }
        }
    }
}

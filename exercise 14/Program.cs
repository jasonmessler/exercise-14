using System;

namespace exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {

            double i;
            string yesOrNo;

            do
            {
                double answer;
                Console.Write("Please enter a number  ");  //resets answer to 0, takes and parses user input
                var userInput = Console.ReadLine();
                var input = double.Parse(userInput);

                for (i = 0; i <= input; i++) // nested loop
                {
                    answer = Math.Pow(i, i); // applies exponentials
                    Console.WriteLine(answer);
                }
            


                Console.WriteLine();  // continue option and return to do/while loop
                Console.Write("Would you like to continue (y/n)?  ");
                yesOrNo = Console.ReadLine();


            } while (yesOrNo == "y");

                Console.WriteLine("Goodbye");
                Console.ReadLine();

            
        }
    }
}

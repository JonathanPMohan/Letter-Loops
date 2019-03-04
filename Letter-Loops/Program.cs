using System;

namespace LetterLoops
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String of Letters.");
            var userInput = Console.ReadLine();
            var userOutput = "";

            for (int i = 0; i < userInput.Length; i++)
            {
                for (int t = 0; t <= i; t++)
                {
                    if (t == 0)
                    {
                        userOutput += userInput[i].ToString().ToUpper();
                    }
                    else
                    {
                        userOutput += userInput[i].ToString().ToLower();
                    }
                }
                if (i != userInput.Length - 1)
                {
                    userOutput += "-";
                }
            }
            Console.WriteLine(userOutput);
            Console.ReadKey();
        }
            
            }
}
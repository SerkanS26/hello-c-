using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is you name? :");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + "! How are you?");
            string userAnswer = Console.ReadLine();
            userAnswer.ToLower();
            //Console.WriteLine("I feel " + userAnswer + " as well, " + userName);

            if (userAnswer == "bad")
            {
                Console.WriteLine("Don't give up " + userName + " everything will be fine!");

            }
            else
            {
                Console.WriteLine("I feel " + userAnswer + " as well, " + userName);
            }
                  






        }
    }
}

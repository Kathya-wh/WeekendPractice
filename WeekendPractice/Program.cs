using System;
using System.Diagnostics.CodeAnalysis;

namespace WeekendPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("We would like to verify you are a human before you enter our platform");
            Console.WriteLine("We will ask you a question that only a human can answer and not a robot, as you can tell we intentionally made a mistake only a human can spot!");

            var theQuestion = "What number is this? (trhee) write the actual number:";
            var theAnswer = "3";
            

            var firstQuestion = new TestMaker(theQuestion, theAnswer);

            firstQuestion.Asking();


            var userInput = Console.ReadLine();

            if (userInput == firstQuestion.Answer)
            {
                Console.WriteLine("That's correct! Verified");
            }
            else
            {
                Console.WriteLine("Sorry, try again");
            }


         

            


















        }
    }
}

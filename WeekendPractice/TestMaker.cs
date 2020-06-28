using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendPractice
{
    class TestMaker
    {
        public TestMaker(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
        public string Question { get; set; }

        public string Answer { get; set; }

        public void Asking()
        {
            Console.WriteLine($"Please answer the question, {Question}");
        }


    }

}

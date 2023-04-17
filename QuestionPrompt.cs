using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PermitTestApp
{
    internal class QuestionPrompt
    {
        private string Answer;
        private string Question;
        private string PlayerAnswer;
        public QuestionPrompt(string promptQuestion, string promptAnswer)
        {
            Answer = promptAnswer;
            Question = promptQuestion;

        }

        public void DisplayPrompt()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(Question);
            Console.Write("Your answer is: ");
            PlayerAnswer = Console.ReadLine();
            Console.WriteLine($"The correct answer is: {Answer}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }
        
        // Conditional Method
        public int CorrectAnswer()
        {
            int Correct = 1;
            int Wrong = 0;
            if (PlayerAnswer == Answer)
            {
                return Correct;
            }

            else return Wrong;
        }
    }
}

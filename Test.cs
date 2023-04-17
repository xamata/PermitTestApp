using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PermitTestApp
{
    internal class Test
    {
        private Examinee CurrentExaminee;
        private QuestionPrompt BikeLaneQuestion, BlindSpotQuestion, YieldQuestion;
        public Test()
        {
            
            string bikeQuestion = "You may drive in a bike lane:\nA. If you drive slower than 15 mph.\nB. No more than 200 feet before making a right turn.\nC. Whenever bicyclists are not present.";
            string blindQuestion = "To see cars in your blind spots, you should check: \nA. The inside rearview mirror.\nB. The outside rearview mirror.\nC. Over your shoulders.";
            string yieldQuestion = "You must yield to a pedestrian using a white cane or guide dog: \nA. Only when a guide dog is leading the person across the street.\nB. At all times.\nC. Only if a crossing guard is present.";
            BikeLaneQuestion = new QuestionPrompt(bikeQuestion, "A");
            BlindSpotQuestion = new QuestionPrompt(blindQuestion, "B");
            YieldQuestion = new QuestionPrompt(yieldQuestion, "C");
            
        }

        public void Run()
        {
            string TestName = "Permit Test";
            Title = TestName;
            WriteLine(@"
  _____                    _ _     _______        _   
 |  __ \                  (_) |   |__   __|      | |  
 | |__) |__ _ __ _ __ ___  _| |_     | | ___  ___| |_ 
 |  ___/ _ \ '__| '_ ` _ \| | __|    | |/ _ \/ __| __|
 | |  |  __/ |  | | | | | | | |_     | |  __/\__ \ |_ 
 |_|   \___|_|  |_| |_| |_|_|\__|    |_|\___||___/\__|
");
            WriteLine("Welcome to your Permit test Practice!");
            WriteLine("What is your name?");
            string examineeName = ReadLine();
            CurrentExaminee = new Examinee(examineeName);

            WriteLine($"Welcome, {CurrentExaminee.Name} to the {TestName}!");

            BikeLaneQuestion.DisplayPrompt();
            CurrentExaminee.Score += BikeLaneQuestion.CorrectAnswer();
            BlindSpotQuestion.DisplayPrompt();
            CurrentExaminee.Score += BlindSpotQuestion.CorrectAnswer();
            YieldQuestion.DisplayPrompt();
            CurrentExaminee.Score += YieldQuestion.CorrectAnswer();

            WriteLine($"Your final score was: {CurrentExaminee.Score}");
            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalityQuiz
{
    class Question
    {
        
        public Question(string text, Character whoChange)
        {
            Text = text;

            WhoChange = whoChange;
        }
        public Question()
        {
            //this is the BindingObject
        }
        public string Text { get; set; }
        public Character WhoChange { get; set; }
        
        public void OnTrue()
        {
            WhoChange.addScore();
        }
        public void OnFalse()
        {
            WhoChange.subScore();
        }

        static Question()
        {
            All = new List<Question>
            {
                new Question("I like to spend time with people!", Character.All[2]), //pathfinder
                new Question("I like to keep moving!", Character.All[2]), //pathfinder
                new Question("I do not like to be on Social Media", Character.All[1]), //crypto
                new Question("I like to stay focused and on topic", Character.All[3]), //revenent
                new Question("I like to take care of people", Character.All[0]) //lifeline
            };
        }
        public static IList<Question> All { private set; get; }
    }
}

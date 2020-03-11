using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalityQuiz
{
    class Character
    {
        public int Score { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        public Character(int score, string name, string bio)
        {
            Score = score;
            Name = name;
            Bio = Bio;
        }

        public void addScore()
        {
            Score++;
        }

        public void subScore()
        {
            Score--;
        }

        static Character()
        {
            All = new List<Character>
            {
                new Character(0, "LifeLine", "Healer, Careing"),    //0
                new Character(0, "Crypto", "You belive that intel wins wars. Off the grid is the best place to be"), //1
                new Character(0, "Pathfinder", "Friendly, fun"), //2
                new Character(0, "Revenent", "on Task, mean") //3
            };
        }
        public static IList<Character> All { private set; get; }
    }
}

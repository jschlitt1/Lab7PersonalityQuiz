using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonalityQuiz
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int QuestionNum = 0;
        public MainPage()
        {
            InitializeComponent();
            label.Text = Question.All[0].Text;
        }
        public void nextQuestion()
        {
            QuestionNum++;
            if(QuestionNum < Question.All.Count())
            {
                label.Text = Question.All[QuestionNum].Text;
            }
            else
            {
                showResult();
            }
            
        }
        public void OnTrue()
        {
            Question.All[QuestionNum].OnTrue();
            nextQuestion();
        }

        public void OnTrueClicked(Object sender, EventArgs arg)
        {
            OnTrue();
        }

        public void OnFalse()
        {
            Question.All[QuestionNum].OnFalse();
            nextQuestion();
        }
        public void OnFalseClicked(Object sender, EventArgs arg)
        {
            OnFalse();
        }

        public void showResult()
        {
            hidebuttons();
            label.Text = "Your Character is: " + Character.HighestScore();
        }

        public void OnSwiped(object sender, SwipedEventArgs args)
        {
            if (args.Direction.ToString() == "Left")
            {
                OnFalse();
            }
            else
            {
                OnTrue();
            }
        }

        public void hidebuttons()
        {
            TrueButton.IsVisible = false;
            FalseButton.IsVisible = false;
        }
    }
}

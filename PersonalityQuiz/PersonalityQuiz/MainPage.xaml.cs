using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

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

        async public void showResult()
        {
            Legend chosenLegend = new Legend();
            hidebuttons();
            label.Text = "Contacting API, please wait...";
            //try {
                List<Legend> legends= await App.LegendListManager.GetTasksAsync();
                foreach(Legend legend in legends)
                {
                //Test.Text = Test.Text + ", " + legend.name;
                if (((legend.name).ToLower()).Equals((Character.HighestScore()).ToLower()))
                    {
                        chosenLegend = legend;
                    }
                }

            //}
            //catch (Exception ex){
               // Debug.WriteLine(@"\tERROR {0}", ex.Message);
             //  label.Text = "Your Character is: " + Character.HighestScore() + "/n Error: There was an Error Contacting the API, Please try again later ";
           // }
            label.Text = "Your Character is: " + Character.HighestScore();
            Description.Text = "Description: " + chosenLegend.description;
            
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

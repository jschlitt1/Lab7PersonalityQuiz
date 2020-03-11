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
        }
        public void nextQuestion()
        {
            QuestionNum++;
            label.Text = Question.All[QuestionNum].Text;
        }
        public void OnTrue()
        {
            //Question.OnTrue();
            //nextQuestion();
        }

        public void OnFalse()
        {
            //Question.OnFalse();
            //nextQuestion();
        }
    }
}

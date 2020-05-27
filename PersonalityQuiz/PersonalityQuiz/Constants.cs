using System;
using Xamarin.Forms;

namespace PersonalityQuiz
{
    public class Constants
    {
        public static string BaseAddress = "https://myapis-jws.azurewebsites.net";
        public static string LegendListUrl = BaseAddress + "/api/legends";
        public static string LegendUrl = BaseAddress + "/api/legends/2";
    }
}

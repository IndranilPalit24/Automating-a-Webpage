using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegsiteringForm
{
    public class Configurationclass
    {
        public static string baseURL = "https://testing.todorvachev.com";
        public static class Valid
        {
            public static string UserId = "asdfasdas";
            public static string Password = "Password";
            public static string username = "Username";
            public static string address = "abcf";
            public static string country = "India";
            public static string Zipcode = "0987079";
            public static string Email = "example@example.com";
            public static string sex = "Male";
            public static string checkbox = "Yes";
            public static string About = "This is a correct description";

        }

        public static class Invalid
        {
            public static string UserId = "asdfas";
            public static string Password = "Pword";
            public static string username = "Urname";
            public static string address = "abcf";
            public static string country = "India";
            public static string Zipcode = "0987079";
            public static string Email = "example.com";
            public static string sex = "Female";
            public static string checkbox = "Yes";
            public static string About = "This is a wrong description";
        }

        public static class Alertstext
        {
            public static string useridoutoflength = "User Id should not be empty / length be between 5 to 12";
        }
    }
}

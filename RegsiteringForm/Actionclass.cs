using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegsiteringForm
{
    public class Actionclass
    {
        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Configurationclass.baseURL);
        }

        public static void fillRegisterForm(string UserId, string Password, string username, string address, string country, string zipcode, string Email, string sex,string checkbox, string About)
        {
            Registerform rsform = new Registerform();

            rsform.UserId.Clear();
            rsform.UserId.SendKeys(UserId);
            
            rsform.Password.Clear();
            rsform.Password.SendKeys(Password);

            rsform.Name.Clear();
            rsform.Name.SendKeys(username);

            rsform.Address.Clear();
            rsform.Address.SendKeys(address);

            //rsform.country.Clear();
            rsform.country.SendKeys(country);

            rsform.Zipcode.Clear();
            rsform.Zipcode.SendKeys(zipcode);

            rsform.Email.Clear();
            rsform.Email.SendKeys(Email);

            rsform.Sex.Click();
            rsform.Sex.Click();

            rsform.CheckBox.Click();
            rsform.CheckBox.Click();

            rsform.About.Clear();
            rsform.About.SendKeys(About);
            


        }

    }
}

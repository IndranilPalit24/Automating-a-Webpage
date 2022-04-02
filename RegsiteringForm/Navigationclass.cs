using RegsiteringForm.UI_Element;
using System;


namespace RegsiteringForm
{
    public class Navigationclass
    {
        public static void Navigatefromthemenu()
        {
            MainMenu menu = new MainMenu();
            TestScenarios tsPage = new TestScenarios();



            menu.TestScenarios.Click();
            tsPage.Clickingonregisterform.Click();
        }
    }
}

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;


namespace RegsiteringForm
{
    public class Registerform
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Registerform()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How=How.Name,Using ="userid")]
        public IWebElement UserId { get; set; }

        [FindsBy(How=How.Name,Using ="passid")]
        public IWebElement Password { get; set; }

        [FindsBy(How=How.Name,Using ="username")]
        public IWebElement Name { get; set; }

        [FindsBy(How=How.Name,Using ="address")]
        public IWebElement Address { get; set; }

        [FindsBy(How=How.Name,Using ="country")]
        public IWebElement country { get; set; }

        [FindsBy(How=How.Name,Using ="zip")]
        public IWebElement Zipcode { get; set; }

        [FindsBy(How=How.Name,Using ="email")]
        public IWebElement Email { get; set; }

        [FindsBy(How=How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(17) > input[type=radio]")]
        public IWebElement Sex { get; set; }

        [FindsBy(How=How.Name,Using ="languageQuestion")]
        public IWebElement CheckBox { get; set; }

        [FindsBy(How=How.Name,Using ="desc")]
        public IWebElement About { get; set; }
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace RegsiteringForm
{
    public class Tests
    {
        IAlert? Alert;

        [OneTimeSetUp]
        public void InitializeDriver()
        {
            Actionclass.InitializeDriver();
            Driver.driver.Manage().Window.Maximize();
            Navigationclass.Navigatefromthemenu();
        }

        [Test]
        public void Test1()
        {
            Actionclass.fillRegisterForm(Configurationclass.Valid.UserId, Configurationclass.Valid.Password, Configurationclass.Valid.username, Configurationclass.Valid.address, Configurationclass.Valid.country, Configurationclass.Valid.Zipcode, Configurationclass.Valid.Email, Configurationclass.Valid.sex, Configurationclass.Valid.checkbox, Configurationclass.Valid.About);
            Thread.Sleep(5000);
            
            //Assert.AreNotEqual(Configurationclass.Alertstext.useridoutoflength, Alert.Text);

        }

        [Test]
        public void Test2()
        {
            Actionclass.fillRegisterForm(Configurationclass.Invalid.UserId, Configurationclass.Invalid.Password, Configurationclass.Invalid.username, Configurationclass.Invalid.address, Configurationclass.Invalid.country, Configurationclass.Invalid.Zipcode, Configurationclass.Invalid.Email, Configurationclass.Invalid.sex, Configurationclass.Invalid.checkbox, Configurationclass.Invalid.About);
            Thread.Sleep(5000);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            Assert.AreEqual(Configurationclass.Alertstext.useridoutoflength, Alert.Text);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            Alert.Accept();

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
            
        }
    }
}
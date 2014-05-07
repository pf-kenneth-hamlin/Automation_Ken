using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAutomation;

namespace UnitTestProject1
{
    [TestClass]
    public class Logout : FluentTest
    {
        public string sampleUrl = "https://sample01-qa01.pf-labs.net";
        // public string sampleUrl = "https://sample02-qa01.pf-labs.net";

        public Logout()
        {
            Settings.DefaultWaitUntilTimeout = TimeSpan.FromSeconds(1);
        }

        [TestMethod]
        public void LogoutChrome()
        {
            FluentAutomation.SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
            I.Open(sampleUrl);
            I.Expect.Text("SSO Application").In(".jumbotron h1");
            I.Click("a:contains('Sign on')");
            //enter user, password and customer key
            I.Enter("peter.harris").In("#UserName");
            I.Enter("peter@harris").In("#Password");
            I.Enter("pf13").In("#CustomerKey");
            I.Press("{TAB}");
            I.Click("button[type='Submit']");
            I.Expect.Exists("a:contains('Sign off')");
            I.Wait(1);
            I.Click("a:contains('sign off')");
            //I should be taken to login page and see a submit button
            I.Expect.Exists("a:contains('Sign on')");
        }

        [TestMethod]
        public void LogoutFirefox()
        {
            FluentAutomation.SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Firefox);
            I.Open(sampleUrl);
            I.Expect.Text("SSO Application").In(".jumbotron h1");
            I.Click("a:contains('Sign on')");
            //enter username, password and customer key
            I.Enter("peter.harris").In("#UserName");
            I.Enter("peter@harris").In("#Password");
            I.Enter("pf13").In("#CustomerKey");
            I.Press("{TAB}");
            I.Click("button[type='Submit']");
            I.Expect.Exists("a:contains('Sign off')");
            I.Wait(1);
            I.Click("a:contains('sign off')");
            //I should be taken to login page and see a submit button
            I.Expect.Exists("a:contains('Sign on')");
        }
    }
}
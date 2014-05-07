using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAutomation;

namespace UnitTestProject1
{
    [TestClass]
    public class InactiveUser : FluentTest
    {
        public string sampleUrl = "https://sample01-qa01.pf-labs.net";
        // public string sampleUrl = "https://sample02-qa01.pf-labs.net";

        public InactiveUser()
        {
            Settings.DefaultWaitUntilTimeout = TimeSpan.FromSeconds(1);
        }

        [TestMethod]
        public void InactiveUserChrome()
        {
            FluentAutomation.SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
            I.Open(sampleUrl);
            I.Expect.Text("SSO Application").In(".jumbotron h1");
            I.Click("a:contains('Sign on')");
            //enter username,password and customer key
            I.Enter("walter.bishop").In("#UserName");
            I.Enter("walter@bishop").In("#Password");
            I.Enter("pf13").In("#CustomerKey");
            I.Press("{TAB}");
            I.Click("button[type='Submit']");
            I.Expect.Exists("a:contains('Sign off')");
            
        }

        [TestMethod]
        public void InactiveUserFirefox()
        {
            FluentAutomation.SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Firefox);
            I.Open(sampleUrl);
            I.Expect.Text("SSO Application").In(".jumbotron h1");
            I.Click("a:contains('Sign on')");
            //enter username,password and customer key
            I.Enter("walter.bishop").In("#UserName");
            I.Enter("walter@bishop").In("#Password");
            I.Enter("pf13").In("#CustomerKey");
            I.Press("{TAB}");
            I.Click("button[type='Submit']");
            I.Expect.Exists("a:contains('Sign off')");
        }
    }
}
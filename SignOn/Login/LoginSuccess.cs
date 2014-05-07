using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAutomation;

namespace UnitTestProject1
{
    [TestClass]
    public class LoginSuccess : FluentTest
    {
        public string sampleUrl = "https://sample01-qa01.pf-labs.net";
        // public string sampleUrl = "https://sample02-qa01.pf-labs.net";

        public LoginSuccess()
        {
            Settings.DefaultWaitUntilTimeout = TimeSpan.FromSeconds(1);
        }

        [TestMethod]
        public void LoginSuccessChrome()
        {   
            FluentAutomation.SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
            I.Open(sampleUrl);
            I.Expect.Text("SSO Application").In(".jumbotron h1");
            I.Click("a:contains('Sign on')");
            //var selectBox = I.Find("select");
            //I.Select("cidp").From(selectBox);
            //var checkBox = I.Find("input:checkbox");
            //I.Click(checkBox);
            //I.Click("input[type='Submit']");
            //enter username,password and customer key
            I.Enter("peter.harris").In("#UserName");
            I.Enter("peter@harris").In("#Password");
            I.Enter("pf13").In("#CustomerKey");
            I.Press("{TAB}");
            I.Click("button[type='Submit']");
            I.Expect.Exists("a:contains('Sign off')");
        }

        [TestMethod]
        public void LoginSuccessFirefox()
        {
            FluentAutomation.SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Firefox);
            I.Open(sampleUrl);
            I.Expect.Text("SSO Application").In(".jumbotron h1");
            I.Click("a:contains('Sign on')");
            //var selectBox = I.Find("select");
            //I.Select("cidp").From(selectBox);
            //var checkBox = I.Find("input:checkbox");
            //I.Click(checkBox);
            //I.Click("input[type='Submit']");
            //enter username,password and customer key
            I.Enter("peter.harris").In("#UserName");
            I.Enter("peter@harris").In("#Password");
            I.Enter("pf13").In("#CustomerKey");
            I.Press("{TAB}");
            I.Click("button[type='Submit']");
            I.Expect.Exists("a:contains('Sign off')");
        }
    }
}
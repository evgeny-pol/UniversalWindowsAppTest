using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;

namespace UITestProj
{
    [TestClass]
    public class UnitTest1
    {
        private const string WindowsApplicationDriverUrl = @"http://127.0.0.1:4723";

        [TestMethod]
        public void TestMethod1()
        {
            var appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", "93011e2b-f3e0-4b2c-9307-fe76414c4d3e_e4thgbjj8qbka!App");
            //using (var appSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities))
            using (var appSession = new IOSDriver<IOSElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities))
            {
                var button1Elem = appSession.FindElementByAccessibilityId("Button1") as IOSElement;
                Assert.IsNotNull(button1Elem);
                button1Elem.Click();
                var textBox1Elem = appSession.FindElementByAccessibilityId("TextBox1") as IOSElement;
                Assert.IsNotNull(textBox1Elem);
                Assert.AreEqual("Hello World!", textBox1Elem.Text);
            }
        }
    }
}
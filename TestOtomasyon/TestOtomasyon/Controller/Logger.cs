using OpenQA.Selenium;
using System;
using TestOtomasyon.Model;

namespace TestOtomasyon.Controller
{
    public class Logger 
    {
        public static WebDriver driver;
       
        public Logger(WebDriver webDriver) => driver = webDriver;

        LogAdd logAdd = new LogAdd();
        
        public void BrowserStartLogger(string messageText, string errorMessageText, WebDriver driver, string elemets)
        {
            try
            {
                driver.Url = elemets;
                logAdd.Add("INFO","Browser Start", messageText,"");
            }
            catch (Exception hata)
            {
                logAdd.Add("INFO", "Browser Start", errorMessageText + hata, "");
                throw;
            }
        }
        public void clickLogger(string messageText, string errorMessageText, IWebElement clickElements)
        {
            try
            {
                clickElements.Click();
                logAdd.Add("INFO", "Click", messageText, "");
            }
            catch (Exception hata)
            {
                logAdd.Add("ERROR", "Click", errorMessageText + hata, "");
            }
        }
        public void sendKeysLogger(string messageText, string errorMessageText, string text,IWebElement sendKeysElements)
        {
            try
            {
                sendKeysElements.SendKeys(text);
                logAdd.Add("INFO", "Click", messageText, "");
            }
            catch (Exception hata)
            {
                logAdd.Add("ERROR", "Click", errorMessageText + hata, "");
            }
        }
        public void Search(string messageText, string errorMessageText, IWebElement sendKeysElements)
        {
            try
            {
                sendKeysElements.SendKeys(Keys.Return);
                logAdd.Add("INFO", "Click", messageText, "");

            }
            catch (Exception hata)
            {
                logAdd.Add("ERROR", "Click", errorMessageText + hata, "");
            }
        }
        public void switchLogger(string messageText, string errorMessageText, IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Window(driver.WindowHandles[0]);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles[0]);
                logAdd.Add("INFO", "SwitchUrl", messageText +" "+ driver.Url, driver.Url);
            }
            catch (Exception hata)
            {
                logAdd.Add("ERROR", "Click", errorMessageText + hata, "");
            }
        }
    }
}

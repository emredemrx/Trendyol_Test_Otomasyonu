using OpenQA.Selenium;
namespace TestOtomasyon.Controller
{
    public class Elements
    {
        public static WebDriver driver;
        public Elements(WebDriver webDriver) => driver = webDriver;

        Locators locators = new Locators();
        
        public WebElement FirstPopupClose()
        {
            return (WebElement)driver.FindElement(By.ClassName(locators.First_Popup_Close));
        }
        //-----------login işlemleri-----------
        public WebElement LoginPageButton()
        {
            return (WebElement)driver.FindElement(By.ClassName(locators.Login_Page_Button));
        }
        public WebElement LoginMailWrite()
        {
            return (WebElement)driver.FindElement(By.Id(locators.Login_Input_Mail.ToString()));
        }
        public WebElement LoginPasswordWrite()
        {
            return (WebElement)driver.FindElement(By.Id(locators.Login_Input_Password));
        }
        public WebElement LoginFormButtonClick()
        {
            return (WebElement)driver.FindElement(By.ClassName(locators.Login_Form_Button));
        }

        //-----------search işlemleri-------------
        public WebElement WriteSearchText()
        {
            return (WebElement)driver.FindElement(By.ClassName(locators.Search_Input));
        }
        //-----------alert kapama-----------
        public WebElement CloseTutorialAlert()
        {
            return (WebElement)driver.FindElement(By.ClassName(locators.Close_Tutorial_Alert));
        }

        //-----------filter search işlemleri-----------
        public WebElement WriteFilterSearchInput()
        {
            return (WebElement)driver.FindElement(By.ClassName(locators.Filter_Search_Input));
        }
        public WebElement FilterSearchSelection()
        {
            return (WebElement)driver.FindElement(By.ClassName(locators.Filter_Search_Selection));
        }

        //-----------fiyat filtresi-----------
        public WebElement SelectBoxClick()
        {
            return (WebElement)driver.FindElement(By.ClassName(locators.Select_Box));
        }
        public WebElement RankSelection()
        {
            return (WebElement)driver.FindElement(By.CssSelector(locators.Rank_Selection));
        }

        //-----------ürün seçimi-----------
        public WebElement ProductSelection()
        {
            return (WebElement)driver.FindElement(By.CssSelector(locators.Product_Selection));
        }

        //-----------sepet ekleme-----------
        public WebElement AddBasketProduct()
        {
            return (WebElement)driver.FindElement(By.ClassName(locators.Add_Basket_Product));
        }
    }
}

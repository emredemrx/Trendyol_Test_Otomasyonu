/*|
 *|  Emre Demir
 *|  Linkedin : @emredemr
 *|  github : @emredemrx
 *|  medium : @emredemr
 *|  Mail : femredemir699@gmail.com
 *|  İnstagram : @emredemr_
 *|                                     
 *|
 */
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TestOtomasyon.Controller;

namespace TestOtomasyon
{
    class Program
    {
        private static WebDriver driver;
        
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            Logger logger = new Logger((WebDriver) driver);
            Elements elements = new Elements((WebDriver) driver);

            logger.BrowserStartLogger("Tarayıcı Başlatıldı :",  "Browser Failed to Start : ",  driver,  "https://www.trendyol.com/");

            logger.clickLogger("Acilir pencere kapatildi", "Acilir pencere kapatilamadi", elements.FirstPopupClose());
            logger.clickLogger("Login Sayfasina Giris icin Tiklandi", "Login Sayfasına Giriş Yapılamadı", elements.LoginPageButton());

            User user = new User();
            logger.sendKeysLogger("Email Yazıldı", "Email Yazılamadı", user.email.ToString(), elements.LoginMailWrite());
            logger.sendKeysLogger("Password Yazıldı", "Password Yazılamadı", user.password.ToString(), elements.LoginPasswordWrite());
           
            logger.clickLogger("Giriş için Tıklandı", "Giriş için Tıklanamadı", elements.LoginFormButtonClick());
            wait(3000);

            SerachText serachText = new SerachText();
            logger.sendKeysLogger("Arama için deger yazıldı", "Aranacak deger yazılamadı", serachText.searchProduct.ToString(),elements.WriteSearchText());
            logger.Search("Arama için tıklama yapıldı", "Arama yapılamadı", elements.WriteSearchText());
            CoveredWait(driver);

            logger.clickLogger("Alert Kapatıldı", "Alert Kapatılamadı", elements.CloseTutorialAlert());

            logger.sendKeysLogger("Filtre Araması için ("+ serachText.filterSearch + ") yazıldı.", "Filtre araması için deger yazılamadı", serachText.filterSearch.ToString(), elements.WriteFilterSearchInput());
            logger.clickLogger("Filtre Seçildi", "Filtre Seçilemedi", elements.FilterSearchSelection());
            wait(2000);

            logger.clickLogger("Sırlama Seçimi için Tıklandı", "Sırlama Seçimi için Tıklanamadı", elements.SelectBoxClick()); 
            logger.clickLogger("Sırlama Seçildi", "Sırlama Seçilemedi", elements.RankSelection());
            wait(1500);

            logger.clickLogger("Ürün seçildi", "Ürün Seçilemedi", elements.ProductSelection());
            logger.switchLogger("","", driver);
            wait(1000); // sayfa yüklenmesi

            logger.clickLogger("Sepete Eklendi", "Sepete Eklenemedi", elements.AddBasketProduct());
            wait(1000);

            driver.Quit();//testi sonlandırdım
        }

        private static void CoveredWait(WebDriver webDriver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);// örtülü bekleme
        }

        public static void wait(int e)
        {
            Thread.Sleep(e);
        }
    }
}

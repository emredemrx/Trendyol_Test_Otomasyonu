namespace TestOtomasyon.Controller
{
    public class Locators
    {
        
        public string First_Popup_Close = "modal-close";
        public string Login_Page_Button = "user-login-container";

        //-----------login işlemleri-----------
        public string Login_Input_Mail = "login-email";
        public string Login_Input_Password = "login-password-input";
        public string Login_Form_Button = "q-primary";

        //-----------search işlemleri-------------
        public string Search_Input = "search-box";

        //-----------alert kapama-----------
        public string Close_Tutorial_Alert = "overlay";

        //-----------filter search işlemleri-----------
        public string Filter_Search_Input = "fltr-srch-inpt";
        public string Filter_Search_Selection = "fltr-item-text";

        //-----------fiyat filtresi-----------
        public string Select_Box = "sort-fltr-cntnr";
        public string Rank_Selection = "option[value*='PRICE_BY_ASC']";

        //-----------ürün seçimi-----------
        public string Product_Selection = ".p-card-wrppr:nth-child(1)";

        //-----------sepet ekleme-----------
        public string Add_Basket_Product = "add-to-basket";
    }
    public class User 
    {
        public string email = "MAİL_ADRESİ_BURAYA";
        public string password = "ŞİFRE_BURAYA";
    }
    public class SerachText
    {
        public string searchProduct = "Samsung s20";
        public string filterSearch = "cep telefon";
    }
}

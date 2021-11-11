using OpenQA.Selenium;
using System.Threading;

namespace Selenium.POM
{
    class AccountSetting
    {
        private readonly IWebDriver _webDriver;

        private readonly By _goToAccount = By.CssSelector("[class='MainHeader__staticItemAvatar--3LwWp MainHeader__staticItem--2UY1x ']");
        private readonly By _addACardName = By.CssSelector("input[placeholder =\"Full name\"]");
        private readonly By _addACardNumber = By.CssSelector("input[name=\"cardnumber\"]");
        private readonly By _addACardDate = By.CssSelector("input[placeholder=\"MM / YY\"]");
        private readonly By _addACardCVV = By.CssSelector("input[placeholder=\"CVC\"]");
        private readonly By _goToCasdSetting = By.CssSelector("iframe[title=\"Secure card payment input frame\"]");

        private readonly By _changeGeneral = By.CssSelector("[class='ng-untouched ng-pristine ng-valid'] [class='edit-switcher__icon_type_edit']");
        private readonly By _changeGeneralWhenChange = By.CssSelector("[class='ng-valid ng-touched ng-pristine'] [class='edit-switcher__icon_type_edit']");

        private readonly By _changeEmail = By.CssSelector("nb-account-info-email-address [class='edit-switcher__icon_type_edit']");
        private readonly By _changePassword = By.CssSelector("nb-account-info-password [class='edit-switcher__icon_type_edit']");
        private readonly By _changePhone = By.CssSelector("nb-account-info-phone [class='edit-switcher__icon_type_edit']");

        private readonly By _changeFirstName = By.CssSelector("input[placeholder='Enter First Name']");
        private readonly By _changeLastName = By.CssSelector("input[placeholder='Enter Last Name']");
        private readonly By _checkLastName = By.XPath("//common-border/div[1]/div/nb-account-info-general-information/form/div[2]/div/nb-paragraph[2]/div");
        private readonly By _checkIndustry = By.XPath("//common-border/div[1]/div/nb-account-info-general-information/form/div[2]/div/nb-paragraph[4]");
        private readonly By _inputConfirmPasswd = By.CssSelector("input[placeholder='Enter Current Password']");
        private readonly By _inputPasswd = By.CssSelector("input[placeholder='Enter New Password']");

        private readonly By _changeLocation = By.CssSelector("input[placeholder='Enter Company Location']");
        private readonly By _checkLocation = By.XPath("//common-border/div[1]/div/nb-account-info-general-information/form/div[2]/div/nb-paragraph[3]/div");
        private readonly By _changeIndustry = By.CssSelector("input[placeholder='Enter Industry']");
        private readonly By _saveGeneral = By.XPath("//common-input[@formcontrolname='first_name']/..//button");
        private readonly By _savePassword = By.XPath("//common-input[@formcontrolname='newPasswordConfirmation']/..//button");
        private readonly By _saveCard = By.XPath("//common-input[@formcontrolname='name']/..//button");

        private readonly By _mainPage = By.CssSelector("[class='HeaderLine__logo--104lH ']");
        private readonly By _logOut = By.CssSelector("[class='link link_type_logout link_active']");
        private readonly By _checkAddACard = By.CssSelector("nb-header[type='sub-page']>div[class='header header_type_sub-page']");

        public AccountSetting(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AccountSetting GoToAccountSetting()
        {
            _webDriver.FindElement(_goToAccount).Click();
            return this;
        }

        public AccountSetting ChengeGeneral()
        {
            _webDriver.FindElement(_changeGeneral).Click();
            return this;
        }

        public AccountSetting ChangeFirstName(string firstName)
        {
            _webDriver.FindElement(_changeFirstName).Clear();
            _webDriver.FindElement(_changeFirstName).SendKeys(firstName);
            return this;
        }

        public void GoToMainPage()
        {
            _webDriver.FindElement(_mainPage).Click();
        }

        public AccountSetting ChangeLastName(string lastName)
        {
            _webDriver.FindElement(_changeLastName).Clear();
            _webDriver.FindElement(_changeLastName).SendKeys(lastName);
            return this;
        }

        public AccountSetting ChangeIndustry(string industry)
        {
            _webDriver.FindElement(_changeIndustry).Clear();
            _webDriver.FindElement(_changeIndustry).SendKeys(industry);
            return this;
        }

        public AccountSetting InputCompanyAddress(string address)
        {
            _webDriver.FindElement(_changeLocation).SendKeys(address);
            Thread.Sleep(1500);
            _webDriver.FindElement(_changeLocation).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            _webDriver.FindElement(_changeLocation).SendKeys(Keys.Enter);
            return this;
        }

        public AccountSetting ChangeEmail()
        {
            _webDriver.FindElement(_changeEmail).Click();
            return this;
        }

        public AccountSetting ChangePassword()
        {
            _webDriver.FindElement(_changePassword).Click();
            return this;
        }

        public AccountSetting ChangePhone()
        {
            _webDriver.FindElement(_changePassword).Click();
            return this;
        }

        public AccountSetting SaveChange()
        {
            _webDriver.FindElement(_saveGeneral).Click();
            return this;
        }

        public AccountSetting SaveChangePassword()
        {
            _webDriver.FindElement(_savePassword).Click();
            Thread.Sleep(1000);
            return this;
        }

        public string CheckName()
        {
            return _webDriver.FindElement(_checkLastName).Text;
        }

        public string CheckLocation()
        {
            return _webDriver.FindElement(_checkLocation).Text;
        }

        public AccountSetting ChangeCompanyAddress(string address)
        {
            _webDriver.FindElement(_changeLocation).Click();
            _webDriver.FindElement(_changeLocation).SendKeys(Keys.Control + "a");
            _webDriver.FindElement(_changeLocation).SendKeys(Keys.Delete);
            _webDriver.FindElement(_changeLocation).Clear();
            Thread.Sleep(1500);
            _webDriver.FindElement(_changeLocation).SendKeys(address);
            Thread.Sleep(1500);
            _webDriver.FindElement(_changeLocation).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            _webDriver.FindElement(_changeLocation).SendKeys(Keys.Enter);
            Thread.Sleep(500);
            return this;
        }

        public string CheckIndustry()
        {
            return _webDriver.FindElement(_checkIndustry).Text;
        }

        public AccountSetting InputCurrentPaswd(string pswd)
        {
            _webDriver.FindElement(_inputConfirmPasswd).SendKeys(pswd);
            return this;
        }

        public AccountSetting InputNewPaswd(string pswd)
        {
            _webDriver.FindElements(_inputPasswd)[0].SendKeys(pswd);
            return this;
        }

        public AccountSetting InputNewPaswdConfirm(string pswd)
        {
            _webDriver.FindElements(_inputPasswd)[1].SendKeys(pswd);
            return this;
        }

        public void ButtonLogOut()
        {
            _webDriver.FindElement(_logOut).Click();
        }
    }
}

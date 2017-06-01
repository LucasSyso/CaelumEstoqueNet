using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumEstoqueTest.Pages
{
    /* LoginPage class
     * 
     * Encapsula comportamentos e atributos da página de login,
     * implementando assim o design pattern PageObject.
     */
    class LoginPage : CaelumEstoquePage
    {
        public static string Path { get; } = "/login";
        public static string Url { get; } =
            UrlBase + Path;


        private IWebDriver Driver;

        public IWebElement SubmitButton
        {
            get {
                return this.Driver
                            .FindElement(By.Id("login-submit"));
            }
        }

        public LoginPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

    }
}

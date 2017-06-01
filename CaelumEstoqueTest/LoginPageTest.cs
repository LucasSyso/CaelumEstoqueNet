using CaelumEstoqueTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumEstoqueTest
{
    /* LoginPageTest class
     * 
     * Encapsula os testes de aceitação feitos com o Selenium
     * com base na página de login do sistema.
     * 
     * IMPORTANTE: Para executar esses testes a aplicação
     * deve estar sendo executada pelo servidor de 
     * desenvolvimento.
     */
    [TestClass]
    public class LoginPageTest
    {
        [TestMethod]
        public void PaginaLoginAcessivel()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(LoginPage.Url);
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d => d.Url.EndsWith(LoginPage.Path, StringComparison.OrdinalIgnoreCase));

                Assert.IsTrue(driver.Url.EndsWith(LoginPage.Path, StringComparison.OrdinalIgnoreCase));
            }
        }

        [TestMethod]
        public void BotaoSubmitExistente()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(LoginPage.Url);

                var loginPage = new LoginPage(driver);

                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement submitButton = wait.Until(d => loginPage.SubmitButton);

                Assert.IsNotNull(submitButton);
            }
        }
    }
}

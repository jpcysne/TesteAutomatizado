using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizado.Bizagi
{
    public class BizagiPage
    {
        private IWebDriver driver;

        public BizagiPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void visita()
        {
            //driver.Navigate().GoToUrl(new URLDaAplicacao().GetUrlBase() + "/usuarios");
            driver.Navigate().GoToUrl("http://p4notedev09/DeveloperAssessment/");
        }

        public void preenche()
        {
            IWebElement txtUser = driver.FindElement(By.Id("username"));
            IWebElement txtSubmit = driver.FindElement(By.Id("btn-login"));
            IWebElement txtNome1 = driver.FindElement(By.XPath(""));
            IWebElement txtValor1 = driver.FindElement(By.XPath(""));

            txtUser.SendKeys("domain\admon");
            txtUser.Submit();
            txtSubmit.Click();



        }


    }
}

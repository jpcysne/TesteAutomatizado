using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizado.Bizagi
{
    public class BizagiMenuPrinc
    {
        private IWebDriver driver;

        public BizagiMenuPrinc(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void newCase()
        {
            IWebElement txtbotaoCase = driver.FindElement(By.XPath("//li[@id='menuListNew']/a/span"));
            IWebElement txtList = driver.FindElement(By.XPath("//li[@id='casesList']/i"));
            IWebElement txtNome1 = driver.FindElement(By.XPath("//*[@id='categories']/ul[1]/li/span"));
            IWebElement txtValor1 = driver.FindElement(By.XPath("//a[contains(text(),'Request assessment')]"));

            txtbotaoCase.Click();
            txtList.Click();
            txtNome1.Click();
            txtValor1.Click();
        }


    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAutomatizado.Bizagi;

namespace TesteAutomatizado.Teste
{
    [TestFixture]
    class BizagiSystemTest
    {
        private IWebDriver driver;
        private BizagiPage bizagi;
        private BizagiMenuPrinc bizagiInicial;
        private TimeSpan timer = TimeSpan.FromSeconds(10);
        [SetUp]
        public void AntesDosTestes()
        {
            driver = new ChromeDriver(@"C:\Users\joaopaulo\Documents\Visual Studio 2017\Projects\TesteAutomatizado\TesteAutomatizado\bin\Debug");
            bizagi = new BizagiPage(driver);

            WebDriverWait wait = new WebDriverWait(driver, timer );
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("modal-content")));

        }

        [TearDown]
        public void DepoisDosTestes()
        {
            driver.Close();
        }
        [Test]
        public void AndarProjeto()
        {
            bizagi = new BizagiPage(driver);
            bizagi.visita();
            bizagi.preencheLogin();

            bizagiInicial = new BizagiMenuPrinc(driver);
            bizagiInicial.NewCase();
        }

    }
}

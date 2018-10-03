using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        [SetUp]
        public void AntesDosTestes()
        {
            driver = new ChromeDriver(@"C:\Users\joaopaulo\Documents\Visual Studio 2017\Projects\TesteAutomatizado\TesteAutomatizado\bin\Debug");
            bizagi = new BizagiPage(driver);
            IWebElement element = new WebDriverWait(driver, 10).until(ExpectedConditions.presenceOfElementLocated(By.className("modal-content")));

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
            bizagi.preenche();

            bizagiInicial = new BizagiMenuPrinc(driver);
            bizagiInicial.newCase();
        }

    }
}

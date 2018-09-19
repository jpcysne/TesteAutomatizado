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
        private PaginaInicial bizagi;
        
        [SetUp]
        public void AntesDosTestes()
        {
            driver = new ChromeDriver(@"D:\Projetos Visual Studio\TesteAutomatizado\TesteAutomatizado\bin\Debug");
            bizagi = new PaginaInicial(driver);

        }

        [TearDown]
        public void DepoisDosTestes()
        {
            driver.Close();
        }
        [Test]
        public void AndarProjeto()
        {
            bizagi = new PaginaInicial(driver);

            bizagi.preenche();
        }

    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TesteAutomatizado.Page;

namespace TesteAutomatizado.Teste
{
    [TestFixture]
    class UsuarioSystemTest
    {

        private IWebDriver driver;
        private UsuarioPage usuario;

        [SetUp]
        public void AntesDosTestes()
        {
            driver = new ChromeDriver();
            usuario = new UsuarioPage(driver);
        }

        [TearDown]
        public void DepoisDosTestes()
        {
            driver.Close();
        }

        [Test]
        public void DeletaUmUsuario()
        {
            UsuarioPage usuario = new UsuarioPage(driver);

            usuario.visita();

            usuario.Novo().cadastra("Renan", "renan.saggio@gmail.com");

            usuario.deletaUsuarioNaPosicao(1);

            Assert.IsFalse(usuario.existeNaListagem("Renan", "renan.saggio@gmail.com"));

        }

        [Test]
        public void DeveAlterarUmUsuario()
        {

            usuario.visita();
            usuario.Novo().cadastra("Renan", "renan@caelum.com.br");

            usuario.Altera(1).Para("Renan Saggio", "renan@caelum.com");

            Assert.IsFalse(usuario.existeNaListagem("Renan", "renan@caelum.com.br"));
            Assert.IsTrue(usuario.existeNaListagem("Renan Saggio", "renan@caelum.com.br"));

        }


        [Test]
        public void deveCadastrarUmUsuario()
        {

            usuario.visita();

            usuario.Novo().cadastra("Renan", "renan.saggio@gmail.com");

            Assert.IsTrue(usuario.existeNaListagem("Renan", "renan.saggio@gmail.com"));


            /*
            driver.Navigate().GoToUrl("");

            IWebElement campoNome = driver.FindElement(By.Name(""));
            IWebElement campoEmail = driver.FindElement(By.Name(""));
            IWebElement botaoSalvar = driver.FindElement(By.Id(""));

            campoEmail.SendKeys("");
            campoNome.SendKeys("");

            campoNome.Submit();
            campoEmail.Submit();

            botaoSalvar.Click();

            bool achouNome = driver.PageSource.Contains("");
            bool achouEmail = driver.PageSource.Contains("");

            Assert.IsTrue(achouNome);
            Assert.IsTrue(achouEmail);

            driver.Close();
            */

        }
    }
}

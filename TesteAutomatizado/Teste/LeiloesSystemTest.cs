using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAutomatizado.Page;

namespace TesteAutomatizado.Teste
{
    [TestFixture]
    class LeiloesSystemTest
    {

        private LeiloesPage leiloes;
        private IWebDriver driver;

        [SetUp]
        public void inicializa()
        {
            driver = new ChromeDriver();
            leiloes = new LeiloesPage(driver);

            UsuarioPage usuarios = new UsuarioPage(driver);
            usuarios.visita();

            usuarios.Novo().cadastra("Paulo Henrique", "paulo@caelum.com.br");
        }

        [Test]
        public void deveCadastrarUmLeilao()
        {

            leiloes.visita();
            NovoLeilaoPage novoLeilao = leiloes.novo();
            novoLeilao.preenche("Geladeira", 123, "Paulo Henrique", true);

        }

        [Test]
        public void validacaoDeValorApareceu()
        {
            leiloes.visita();
            leiloes.novo().preenche("Geladeira", 0, "Paulo Henrique", false);
            Assert.IsTrue(driver.PageSource.Contains("Valor inicial deve ser maior que zero!"));
        }
    }
}

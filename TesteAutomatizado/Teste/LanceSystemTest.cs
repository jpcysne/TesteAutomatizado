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
    class LanceSystemTest
    {
        private IWebDriver driver;
        private LeiloesPage leiloes;
        private DetalhesDoLeilaoPage lances;
        [SetUp]
        public void inicializa()
        {
            driver = new ChromeDriver(@"D:\Projetos Visual Studio\TesteAutomatizado\TesteAutomatizado\bin\Debug");
            leiloes = new LeiloesPage(driver);
            UsuarioPage usuario = new UsuarioPage(driver);
            usuario.visita();
            usuario.Novo().cadastra("Renan Saggio", "renan@caelum.com.br");
            usuario.Novo().cadastra("Paulo Henrique", "paulo@caelum.com.br");
            leiloes.novo().preenche("Geladeira", 250, "Renan Saggio", true);
        }
        [Test]
        public void DeveDarLance()
        {
            leiloes.visita();

            DetalhesDoLeilaoPage lances = leiloes.Detalhes(1);

            lances.lance("Paulo Henrique", 150);

            Assert.IsTrue(lances.existeLance("Paulo Henrique", 150));
        }

        [SetUp]
        public void CriaCenario()
        {
            lances = new DetalhesDoLeilaoPage(driver);


            new CriadorDeCenarios(driver)
                .umUsuario("Paulo Henrique", "paulo@henrique.com")
                .umUsuario("José Alberto", "jose@alberto.com")
                .umLeilao("Paulo Henrique", "Geladeira", 100, false);

        }
    }
}

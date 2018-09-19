using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizado.Page
{
    public class LeiloesPage
    {
        private IWebDriver driver;

        public LeiloesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void visita()
        {
            driver.Navigate().GoToUrl("http://localhost:8080/leiloes");

        }

        public NovoLeilaoPage novo()
        {
            driver.FindElement(By.LinkText("Novo Leilão")).Click();
            return new NovoLeilaoPage(driver);
        }

        public bool existe(string produto, double valor, string usuario, bool usado)
        {
            return driver.PageSource.Contains(produto) &&
                    driver.PageSource.Contains(Convert.ToString(valor)) &&
                    driver.PageSource.Contains(usuario) &&
                    driver.PageSource.Contains(usado ? "Sim" : "Não");
        }
        public DetalhesDoLeilaoPage Detalhes(int posicao)
        {
            driver.FindElements(By.LinkText("exibir"))[posicao - 1].Click();
            return new DetalhesDoLeilaoPage(driver);

        }
    }
}

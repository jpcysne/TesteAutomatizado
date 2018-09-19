using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizado.Page
{
    public class UsuarioPage
    {

        private IWebDriver driver;

        public UsuarioPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void visita()
        {
            driver.Navigate().GoToUrl(new URLDaAplicacao().GetUrlBase() + "/usuarios");
            // antigo: driver.Navigate().GoToUrl("http://localhost:8080/usuarios");
        }

        public NovoUsuarioPage Novo()
        {
            driver.FindElement(By.LinkText("Novo Usuário")).Click();
            return new NovoUsuarioPage(driver);
        }
        

        public bool existeNaListagem(String nome, String email)
        {
            return driver.PageSource.Contains(nome) &&
            driver.PageSource.Contains(email);

        }

        public void deletaUsuarioNaPosicao(int posicao)
        {
            driver.FindElements(By.TagName("button"))[posicao - 1].Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

        }
        public AlteraUsuarioPage Altera(int posicao)
        {
            driver.FindElements(By.LinkText("editar"))[posicao - 1].Click();
            return new AlteraUsuarioPage(driver);
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizado.Page
{
    public class AlteraUsuarioPage
    {
        private IWebDriver driver;

        public AlteraUsuarioPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public UsuarioPage Para(string nome, string email)
        {
            IWebElement txtNome = driver.FindElement(By.Name("usuario.nome"));
            IWebElement txtEmail = driver.FindElement(By.Name("usario.email"));

            txtNome.SendKeys(nome);
            txtEmail.SendKeys(email);

            txtNome.Submit();

            return new UsuarioPage(driver);
        }
    }
}

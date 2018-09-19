using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizado.Bizagi
{
    public class PaginaInicial
    {
        private IWebDriver driver;

        public PaginaInicial(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void preenche(string nome, double valor, string usuario, bool usado)
        {
            IWebElement txtNome = driver.FindElement(By.XPath(""));
            IWebElement txtValor = driver.FindElement(By.XPath(""));
            IWebElement txtNome1 = driver.FindElement(By.XPath(""));
            IWebElement txtValor1 = driver.FindElement(By.XPath(""));

            txtNome.SendKeys(nome);
            txtValor.SendKeys(Convert.ToString(valor));

            SelectElement cbUsuario = new SelectElement(driver.FindElement(By.Name("leilao.usuario.id")));

            cbUsuario.SelectByText(usuario);

            if (usado)
            {
                IWebElement ckUsado = driver.FindElement(By.Name("leilao.usado"));
                ckUsado.Click();
            }

            txtNome.Submit();


        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TesteAutomatizado.Page
{
    public class NovoLeilaoPage
    {

        private IWebDriver driver;

        public NovoLeilaoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void preenche(string nome, double valor, string usuario, bool usado)
        {
            IWebElement txtNome = driver.FindElement(By.Name("leilao.nome"));
            IWebElement txtValor = driver.FindElement(By.Name("leilao.valorInicial"));

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

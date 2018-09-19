using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizado.Page
{
    class CriadorDeCenarios
    {
        private IWebDriver driver;

        public CriadorDeCenarios(IWebDriver driver)
        {
            this.driver = driver;
        }

        public CriadorDeCenarios umUsuario(string nome, string email)
        {
            UsuarioPage usuarios = new UsuarioPage(driver);
            usuarios.visita();
            usuarios.Novo().cadastra(nome, email);

            return this;
        }

        public CriadorDeCenarios umLeilao(string usuario,
                    string produto,
                    double valor,
                    Boolean usado)
        {
            LeiloesPage leiloes = new LeiloesPage(driver);
            leiloes.visita();
            leiloes.novo().preenche(produto, valor, usuario, usado);

            return this;
        }
    }
}

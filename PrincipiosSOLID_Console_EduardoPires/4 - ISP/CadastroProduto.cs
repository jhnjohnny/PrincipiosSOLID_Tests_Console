using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.ISP
{
    public class CadastroProduto : ICadastroProduto
    {
        public string SalvarBanco()
        {
            return "Com sucesso";
        }

        public bool ValidarDados()
        {
            return true;
        }
    }
}

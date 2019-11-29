using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.ISP
{
    public class CadastroCliente : ICadastroCliente
    {
        public bool EnviarEmail()
        {
            return true;
        }

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

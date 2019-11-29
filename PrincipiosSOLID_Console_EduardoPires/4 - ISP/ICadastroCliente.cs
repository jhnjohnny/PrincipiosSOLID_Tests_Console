using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.ISP
{
    public interface ICadastroCliente
    {
        bool ValidarDados();
        string SalvarBanco();
        bool EnviarEmail();
    }
}

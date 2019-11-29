using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.ISP
{
    public interface ICadastroProduto
    {
        bool ValidarDados();
        string SalvarBanco();
    }
}

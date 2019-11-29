using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.Praticar
{
    public interface IEmailServices
    {
        bool IsValid(string email);

        void Enviar(string de, string para, string assunto, string mensagem);
    }
}

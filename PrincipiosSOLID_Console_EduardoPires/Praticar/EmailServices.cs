using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.Praticar
{
    public class EmailServices : IEmailServices
    {
        public void Enviar(string de, string para, string assunto, string mensagem)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(string email)
        {
            return email.Contains("@");
        }
    }
}

using PrincipiosSOLID_Console_EduardoPires.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.DIP
{
    public class EmailServices : IEmailServices
    {
        public void Enviar(string de, string para, string assunto, string mensagem)
        {
            var mail = new MailMessage(de, para);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = assunto;
            mail.Body = mensagem;

            client.Send(mail);
        }

        public bool IsValid(string email)
        {
            return email.Contains("@");
        }
    }
}

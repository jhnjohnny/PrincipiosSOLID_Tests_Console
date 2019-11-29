using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.Praticar
{
    public class Cliente
    {
        // INJEÇÃO DE DEPENDÊNCIAS
        private readonly IEmailServices _emailServices;
        private readonly ICPFServices _cPFServices;

        public Cliente(IEmailServices emailServices, ICPFServices cPFServices)
        {
            _emailServices = emailServices;
            _cPFServices = cPFServices;
        }


        // PROPRIEDADES
        public int ClienteId { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataCadastro { get; private set; }


        // VALIDAÇÃO
        public bool IsValid()
        {
            return _emailServices.IsValid(Email) && _cPFServices.IsValid(CPF);
        }
    }
}

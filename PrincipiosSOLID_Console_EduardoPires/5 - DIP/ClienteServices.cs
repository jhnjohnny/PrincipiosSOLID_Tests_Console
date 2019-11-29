using PrincipiosSOLID_Console_EduardoPires.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.DIP
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteServices(IClienteRepository clienteRepository, IEmailServices emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid()) return "Dados inválidos";

            // Salvar Cliente no Banco de Dados
            _clienteRepository.AdicionarCliente(cliente);

            // Enviar Email de "Boas Vindas"
            _emailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem vindo(a)", "Parabéns! Está Cadastrado!");


            return "Cliente cadastrado com Sucesso!!";
        }
    }
}

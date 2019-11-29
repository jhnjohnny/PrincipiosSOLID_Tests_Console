using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.Praticar
{
    public class ClienteServices : IClienteServices
    {
        // INJEÇÃO DE DEPENDÊNCIAS
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteServices(IClienteRepository clienteRepository,IEmailServices emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }

        // MÉTODOS
        public string AdicionarCliente(Cliente cliente)
        {
            // Validar Dados
            if (!cliente.IsValid()) return "Dados inválidos";

            // Salvar no Banco
            _clienteRepository.AdicionarCliente(cliente);

            // Enviar Email
            _emailServices.Enviar("empresa@empresa.com", "cliente@email.com", "Cadastro realizado", "Bem vindo");

            // Notificar Cliente
            return "Cadastro realizado com Sucesso!";
        }
    }
}

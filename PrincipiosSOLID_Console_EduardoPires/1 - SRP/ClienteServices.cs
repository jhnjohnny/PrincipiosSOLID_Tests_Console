using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.SRP
{
    public class ClienteServices
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid()) return "Dados inválidos";

            // Salvar Cliente no Banco de Dados
            var repo = new ClienteRepository();
            repo.AdicionarClienteBD(cliente);

            // Enviar Email de "Boas Vindas"
            EmailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem vindo(a)", "Parabéns! Está Cadastrado!");


            return "Cliente cadastrado com Sucesso!!";
        }
    }
}

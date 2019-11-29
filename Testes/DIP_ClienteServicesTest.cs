using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrincipiosSOLID_Console_EduardoPires.DIP;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using PrincipiosSOLID_Console_EduardoPires.DIP.Interfaces;

namespace Testes
{
    [TestClass]
    public class DIP_ClienteServicesTest
    {
        private readonly Mock<IClienteRepository> _clienteRepositoryMock;
        private readonly Mock<IEmailServices> _emailServicesMock;

        private readonly ICPFServices _cpfServices;
        private readonly IEmailServices _emailServices;
        private readonly IClienteServices _clienteServices;

        private readonly Cliente _cliente;


        // Construtor
        public DIP_ClienteServicesTest()    // Teste Unitários não "Injeta Dependências" como parâmetros no Construtor.
        {
            _clienteRepositoryMock = new Mock<IClienteRepository>();
            _emailServicesMock = new Mock<IEmailServices>();

            _cpfServices = new CPFServices();
            _emailServices = new EmailServices();
            _clienteServices = new ClienteServices(_clienteRepositoryMock.Object, _emailServicesMock.Object);

            _cliente = new Cliente(_cpfServices, _emailServices)
            {
                ClienteId = 1,
                Nome = "Nome Teste",
                Email = "email@email.com",
                CPF = "11122233344",
                DataCadastro = DateTime.Now
            };
        }


        //[TestMethod]
        //public void CPFIsValid()
        //{
        //    Assert.IsTrue(_cpfServices.IsValid(_cliente.CPF));
        //}

        //[TestMethod]
        //public void EmailIsValid()
        //{
        //    Assert.IsTrue(_emailServices.IsValid(_cliente.Email));
        //}

        [TestMethod]
        public void ClienteIsValid()
        {
            Assert.IsTrue(_cliente.IsValid());
        }


        // Teste de Dados do Cliente
        [TestMethod]
        public void AdicionarClienteDadosValidos()
        {
            string result = _clienteServices.AdicionarCliente(_cliente);

            Assert.AreEqual("Cliente cadastrado com Sucesso!!", result);
        }

        [TestMethod]
        public void AdicionarClienteDadosInvalidos()
        {
            // Arrange (Organização)
            Cliente clienteDadosInvalidos = new Cliente(_cpfServices, _emailServices)
            {
                ClienteId = _cliente.ClienteId,
                Nome = _cliente.Nome,
                Email = "email",
                CPF = "123456",
                DataCadastro = _cliente.DataCadastro
            };

            // Actions (Métodos)
            string result = _clienteServices.AdicionarCliente(clienteDadosInvalidos);

            // Assert (Testes)
            Assert.AreEqual("Dados inválidos", result);

        }
        

    }
}

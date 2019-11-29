using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrincipiosSOLID_Console_EduardoPires.ISP;

namespace Testes
{
    [TestClass]
    public class ISP_ClienteTest
    {
        private readonly CadastroCliente _cadastroCliente;

        public ISP_ClienteTest()
        {
            _cadastroCliente = new CadastroCliente();        
        }

        // TESTE CADASTRO CLIENTE
        [TestMethod]
        public void CadastroClienteValidarDados()
        {
            Assert.IsTrue(_cadastroCliente.ValidarDados());
        }

        [TestMethod]
        public void CadastroClienteSalvarBanco()
        {
            Assert.AreEqual("Com sucesso",_cadastroCliente.SalvarBanco());
        }

        [TestMethod]
        public void CadastroClienteEnviarEmail()
        {
            Assert.IsTrue(_cadastroCliente.EnviarEmail());
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrincipiosSOLID_Console_EduardoPires.ISP;

namespace Testes
{
    [TestClass]
    public class ISP_ProdutoTest
    {
        private readonly CadastroProduto _cadastroProduto;

        public ISP_ProdutoTest()
        {
            _cadastroProduto = new CadastroProduto();        
        }

        // TESTE CADASTRO PRODUTO
        [TestMethod]
        public void CadastroProdutoValidarDados()
        {
            Assert.IsTrue(_cadastroProduto.ValidarDados());
        }

        [TestMethod]
        public void CadastroProdutoSalvarBanco()
        {
            Assert.AreEqual("Com sucesso", _cadastroProduto.SalvarBanco());
        }
    }
}

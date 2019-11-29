using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrincipiosSOLID_Console_EduardoPires.OCP;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace Testes
{
    [TestClass]
    public class OCP_DebitoContaTest
    {
        private readonly DebitoContaCorrente _debitoContaCorrente;

        public OCP_DebitoContaTest()
        {
            _debitoContaCorrente = new DebitoContaCorrente();
        }

        [TestMethod]
        public void DebitoContaCorrenteTeste()
        {
            var debitoConta = new Mock<DebitoConta>();

            var debitoContaCorrente = debitoConta.Setup(s => s.Debitar(10m, "007")) // Entrada
                                                                .Returns("123456"); // Saida

            Assert.IsNotNull(debitoContaCorrente);
        }
    }
}

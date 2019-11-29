using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrincipiosSOLID_Console_EduardoPires.DIP;
using PrincipiosSOLID_Console_EduardoPires.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testes
{
    [TestClass]
    public class DIP_CPFServicesTest
    {
        private readonly ICPFServices _cpfServices;
        private readonly string _cpf;

        public DIP_CPFServicesTest()
        {
            _cpfServices = new CPFServices();
            _cpf = "11122233344";
        }

        [TestMethod]
        public void CPFIsValidSucesso()
        {
            Assert.IsTrue(_cpfServices.IsValid(_cpf));
        }

        [TestMethod]
        public void CPFIsValidErro()
        {
            Assert.IsFalse(_cpfServices.IsValid("123456"));
        }

    }
}

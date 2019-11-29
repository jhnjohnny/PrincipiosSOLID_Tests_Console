using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrincipiosSOLID_Console_EduardoPires.DIP;
using PrincipiosSOLID_Console_EduardoPires.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testes
{
    [TestClass]
    public class DIP_EmailServicesTest
    {
        private readonly IEmailServices _emailServices;
        private readonly string _email;

        public DIP_EmailServicesTest()
        {
            _emailServices = new EmailServices();
            _email = "email@email.com";
        }

        [TestMethod]
        public void EmailIsValidSucesso()
        {
            Assert.IsTrue(_emailServices.IsValid(_email));
        }

        [TestMethod]
        public void EmailIsValidErro()
        {
            Assert.IsFalse(_emailServices.IsValid("emailFalso"));
        }
    }
}

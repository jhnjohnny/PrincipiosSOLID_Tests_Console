using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.Praticar
{
    class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            return NumeroTransacao;
        }
    }
}

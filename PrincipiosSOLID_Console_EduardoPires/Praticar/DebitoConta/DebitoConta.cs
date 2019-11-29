using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.Praticar
{
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }

        public abstract string Debitar(decimal valor, string conta);
    }
}

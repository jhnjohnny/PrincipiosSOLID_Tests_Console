using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.OCP
{
    // ABSTRACT -> Não instânciável, permitindo apenas ser Herdado.
    public abstract class DebitoConta   
    {
        public string NumeroTransacao { get; set; }


        // Para permitir "Extensões" e ser obrigado o Override, 
        // Apenas o "Cabeçalho" do método (semelhante à Interface, 
        // Mas que não permite o Override e nem Propriedades).
        public abstract string Debitar(decimal valor, string conta);
    }
}

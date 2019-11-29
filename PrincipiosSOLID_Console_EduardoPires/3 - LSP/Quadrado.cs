using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.LSP
{
    // SOLUÇÃO CORRETA É NÃO HERDAR, MAS CRIAR INDEPENDENTES 
    // (PARA NÃO INFLUENCIAR, APESAR DE PARECEREM IGUAIS).
    public class Quadrado : Retangulo   
    {
        public override double Altura
        {
            set { base.Altura = base.Largura = value; }
        }

        public override double Largura
        {
            set { base.Altura = base.Largura = value; }
        }
    }
}

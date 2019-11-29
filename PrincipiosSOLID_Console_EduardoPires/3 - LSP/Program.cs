using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.LSP
{
    public class Program
    {

        private static void ObterAreaRetangulo(Retangulo retangulo)
        {
            Console.WriteLine("Calculo da área do Retângulo");
            Console.WriteLine(retangulo.Altura.ToString() + " * " + retangulo.Largura.ToString());
            Console.WriteLine(retangulo.Area);
            Console.ReadKey();
        }

        private static void Main()
        {
            var quad = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quad);
        }
    }
}

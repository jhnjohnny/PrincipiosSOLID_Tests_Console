﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSOLID_Console_EduardoPires.LSP
{
    public class Retangulo
    {
        public virtual double Altura { get; set; }
        public virtual double Largura { get; set; }

        public double Area { get { return Altura * Largura; } }
    }
}

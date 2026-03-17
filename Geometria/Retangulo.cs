using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    internal class Retangulo : Formageometrica
    {
        public double altura;
        public double B;

        public void calcularArea(double altura,double B)
        {
            double area = (altura*B);
            Console.WriteLine("A área do retangulo é: " + area);
        }
    }
}

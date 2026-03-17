using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    internal class Triangulo : Formageometrica
    {
        public double altura;
        public double B;

        public void calcularArea(double altura, double B)
        {
            double area = (altura * B) / 2;
            Console.WriteLine("A área do retangulo é: " + area);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    internal class Circulo : Formageometrica
    {
        public double raio;

        public void calcularArea(double raio)
        {
            double area = 3.14 * (raio * raio);
            Console.WriteLine("A área do círculo é: " + area);
        }
    }
}

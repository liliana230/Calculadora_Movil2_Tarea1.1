using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Calculo
{
    class Operaciones
    {
        public Decimal numero1 { get; set; }
        public Decimal numero2 { get; set; }


        public Decimal suma(Decimal a, Decimal b)
        {
            return a + b;
        }

        public Decimal resta(Decimal a, Decimal b)
        {
            return a - b;
        }

        public Decimal multiplicacion(Decimal a, Decimal b)
        {
            return a * b;
        }

        public Decimal division(Decimal a, Decimal b)
        {
            Decimal result = a / b;
            return result;
        }
    }
}

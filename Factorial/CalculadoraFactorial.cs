using System;

namespace Factorial
{
    public class CalculadoraFactorial
    {
        public CalculadoraFactorial()
        {
        }

        public int CalcularFactorial(int numero)
        {
            if (numero == 0 || numero == 1)
                return 1;
            return numero * CalcularFactorial(numero - 1);
        }
    }
}
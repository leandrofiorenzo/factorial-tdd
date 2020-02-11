using NUnit.Framework;

namespace Factorial.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ElFactorialDe0DebeSer1()
        {
            CalculadoraFactorial calculadoraFactorial = new CalculadoraFactorial();
            int numero = 0;
            int factorialCalculado = calculadoraFactorial.CalcularFactorial(numero);
            int factorialEsperado = 1;
            Assert.AreEqual(factorialEsperado, factorialCalculado);
        }

        [Test]
        public void ElFactorialDe1DebeSer1()
        {
            CalculadoraFactorial calculadoraFactorial = new CalculadoraFactorial();
            int numero = 1;
            int factorialCalculado = calculadoraFactorial.CalcularFactorial(numero);
            int factorialEsperado = 1;
            Assert.AreEqual(factorialEsperado, factorialCalculado);
        }

        [Test]
        public void ElFactorialDe2DebeSer2()
        {
            CalculadoraFactorial calculadoraFactorial = new CalculadoraFactorial();
            int numero = 2;
            int factorialCalculado = calculadoraFactorial.CalcularFactorial(numero);
            int factorialEsperado = 2;
            Assert.AreEqual(factorialEsperado, factorialCalculado);
        }

        [Test]
        public void ElFactorialDe3DebeSer6()
        {
            CalculadoraFactorial calculadoraFactorial = new CalculadoraFactorial();
            int numero = 3;
            int factorialCalculado = calculadoraFactorial.CalcularFactorial(numero);
            int factorialEsperado = 6;
            Assert.AreEqual(factorialEsperado, factorialCalculado);
        }

        [Test]
        public void ElFactorialDe4DebeSer24()
        {
            CalculadoraFactorial calculadoraFactorial = new CalculadoraFactorial();
            int numero = 4;
            int factorialCalculado = calculadoraFactorial.CalcularFactorial(numero);
            int factorialEsperado = 24;
            Assert.AreEqual(factorialEsperado, factorialCalculado);
        }

        [Test]
        public void ElFactorialDe10DebeSer3628800()
        {
            CalculadoraFactorial calculadoraFactorial = new CalculadoraFactorial();
            int numero = 10;
            int factorialCalculado = calculadoraFactorial.CalcularFactorial(numero);
            int factorialEsperado = 3628800;
            Assert.AreEqual(factorialEsperado, factorialCalculado);
        }
    }
}
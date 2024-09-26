using New_Talents;
using System;
using Xunit;
namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora construirclasse()
        {
            string data = "26/09/2024";
            Calculadora calc = new Calculadora("26/09/2024");

            return calc;
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int num1, int num2, int res)
        {
            Calculadora calc = construirclasse();

            int resultado = calc.Somar(num1, num2);

            Assert.Equal(res, resultado);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int num1, int num2, int res)
        {
            Calculadora calc = construirclasse();

            int resultado = calc.Multiplicar(num1, num2);

            Assert.Equal(res, resultado);
        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(4, 5, -1)]
        public void TestSubtrair(int num1, int num2, int res)
        {
            Calculadora calc = construirclasse();

            int resultado = calc.Subtrair(num1, num2);

            Assert.Equal(res, resultado);
        }
        [Theory]
        [InlineData(1, 2, 0.5)]
        [InlineData(8, 2, 4)]
        public void TestDividir(int num1, int num2, int res)
        {
            Calculadora calc = construirclasse();

            int resultado = calc.Dividir(num1, num2);

            Assert.Equal(res, resultado);
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirclasse();
            calc.Somar(1, 2);
            calc.Somar(3, 2);
            calc.Somar(7, 6);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
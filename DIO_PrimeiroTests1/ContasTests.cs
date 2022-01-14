using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Contas.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 5;
            var b = 6;
            var esperado = 11; //O QUE SE ESPERA APÓS A OPERAÇÃO
            var contas = new Contas(); // CHAMA O ARQUIVO Contas

            var result = contas.Soma(a, b); // EXECUTA A OPERAÇÃO Soma DO ARQUIVO Contas através da variável 'contas'

            Assert.AreEqual(esperado, result); //COMPARA ATRAVÉS DE AreEqual o 'esperado' com 'result'
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            var a = 5;
            var b = 6;
            var esperado = -1;
            var contas = new Contas();

            var result = contas.Subtracao(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 1;
            var contas = new Contas();

            var result = contas.Divisao(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            var a = 5;
            var b = 6;
            var esperado = 30;
            var contas = new Contas();

            var result = contas.Multiplicacao(a, b);

            Assert.AreEqual(esperado, result);
        }
    }
}
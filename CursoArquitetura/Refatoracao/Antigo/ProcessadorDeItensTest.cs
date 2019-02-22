using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;

namespace Refatoracao.Antigo
{
    [TestClass]
    public class ProcessadorDeItensTest
    {
        private const string dadosDeTeste = @"3123123;Eletrodomestico;1;1000,00
                                             7567123;Eletrodomestico;3;500,00
                                             3978876;Eletroeletronico;2;700,00
                                             1236543;Movel;7;350,00
                                             9324423;Movel;4;600,00";

        public static Stream GenerateStreamFromString(string s)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(s));
        }

        [TestMethod]
        public void GetItensTest()
        {
            var proc = new ProcessadorDeItens();

            var itens = proc.GetItens(GenerateStreamFromString(dadosDeTeste));

            Assert.AreEqual(5, itens.Count, "Total");
            Assert.AreEqual("3123123" , itens[0].Codigo, "Codigo");
            Assert.AreEqual("Eletrodomestico", itens[1].Tipo, "Tipo");
            Assert.AreEqual(2, itens[2].Quantidade, "Quantidade");
            Assert.AreEqual(350.00, itens[3].ValorUnitario, "Valor Unitário");
        }

        [TestMethod]
        public void GetValorTotalPorTipoTest()
        {
            var proc = new ProcessadorDeItens();
            var totalEletrodomesticos = proc.GetValorTotalPorTipo(GenerateStreamFromString(dadosDeTeste), "Eletrodomestico");
            var totalMovel = proc.GetValorTotalPorTipo(GenerateStreamFromString(dadosDeTeste), "Movel");

            Assert.AreEqual(2500, totalEletrodomesticos);
            Assert.AreEqual(4850, totalMovel);
        }
    }
}

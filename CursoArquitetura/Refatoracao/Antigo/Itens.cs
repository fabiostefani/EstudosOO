using System;
using System.IO;

namespace Refatoracao.Antigo
{
    public class Itens
    {
        public string Codigo { get; private set; }
        public string Tipo { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }

        public void SetarCodigo(string codigo)
        {
            Codigo = codigo;
        }

        public void SetarTipo(string tipo)
        {
            Tipo = tipo;
        }

        public void SetarQuantidade(int quantidade)
        {
            Quantidade = quantidade;
        }

        public void SetarValorUnitario(double valorUnitario)
        {
            ValorUnitario = valorUnitario;
        }

        public void CarregarDaString(StreamReader sr, Itens item)
        {
            var elementos = sr.ReadLine().Split(';');
            item.SetarCodigo(elementos[0]);
            item.SetarTipo(elementos[1]);
            item.SetarQuantidade(Convert.ToInt32(elementos[2]));
            item.SetarValorUnitario(Convert.ToDouble(elementos[3]));
        }

        public double GetValorTotal()
        {
            return ValorUnitario * Quantidade;
        }
    }
}

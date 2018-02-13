using System;
using System.Collections.Generic;
using System.IO;

namespace Refatoracao.Antigo
{
    public class ProcessadorDeItens
    {
        public List<Itens> GetItens(Stream imput)
        {
            var listaItens = new List<Itens>();
            using (StreamReader sr = new StreamReader(imput))
            {
                //var linha = ;

                while (/*linha != null*/sr.Peek() >= 0)
                {
                    var item = new Itens();
                    item.CarregarDaString(sr, item);
                    listaItens.Add(item);
                }
            }
            return listaItens;
        }

        public double GetValorTotalPorTipo(Stream imput, string tipo)
        {
            double valorTotalPorTipo = 0;
            var itens = GetItens(imput);

            foreach (var item in itens)
            {
                valorTotalPorTipo += tipo.Equals(item.Tipo) ? item.GetValorTotal() : 0;
            }
            return valorTotalPorTipo;
        }
    }
}

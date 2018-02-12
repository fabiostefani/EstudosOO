using System;

namespace Arquitetura.OOP
{
    public class Implementacao
    {
        public static void Processo()
        {
            //implementação
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class Abstracao
    {
        private readonly IRepositorio _repositorio;
        public Abstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }
}

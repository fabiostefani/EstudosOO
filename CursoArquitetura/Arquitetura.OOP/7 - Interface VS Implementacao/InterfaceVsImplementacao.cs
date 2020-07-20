using System;

namespace Arquitetura.OOP
{
    public class Implementacao
    {
        public void Processo()
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

    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new Implementacao();
            repoImp.Processo();

            var repAbs = new Abstracao(new Repositorio());
            repAbs.Processo();

            var repAbsFake = new Abstracao(new RepositorioFake());
            repAbsFake.Processo();
        }
    }
}

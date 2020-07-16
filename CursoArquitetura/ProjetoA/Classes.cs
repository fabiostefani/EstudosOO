using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

//[assembly: InternalsVisibleTo("ProjetoB")]
namespace ProjetoA
{

//Modificadores de Acesso
//PUBLIC: acesso publico, sem restrição
//PROTECTED: somente a classe ou quem herda
//INTERNAL: somente dentro do mesmo assembly.
//PROTECTED INTERNAL: acesso somente dentro do mesmo assembly ou através de herança
//PRIVATE: limitado, somente através da propria classe
//PRIVATE PROTECTED: somente para herança ou que estao dentro do mesmo assembly.

    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }

    public sealed class Selada {}
    class Privada { }
    internal class Interna { }
    abstract class Abstrata { }

    #region Testes
    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada();
            var interna = new Interna();
            //var abstrata = new Abstrata(); NÃO É POSSÍVEL PQ ABSTRACT NÃO PODE SER INSTANCIADO
        }

        //class TesteSelada : Selada { } // NÃO PERMITE FAZER A HERANÇA PQ CLASSE SELADA NÃO PERMITE HERANÇA
    }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();            
            publica.TesteInternal();
            publica.TesteProtegidoInterno();
            //publica.TesteProtegido(); //NÃO TERÁ ACESSO, PQ SÓ CLASSES QUE HERDAM PODEM ACESSAR
            //publica.TestePrivadoProtegido(); //NÃO TERÁ ACESSO, PQ SÓ CLASSES QUE HERDAM PODEM ACESSAR
            //publica.TestePrivado(); //PRIVADO NUNCA TERÁ ACESSO
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            TesteInternal();
            TesteProtegidoInterno();
            TesteProtegido();
            TestePrivadoProtegido();            
            //TestePrivado(); //PRIVADO NUNCA TERÁ ACESSO
        }
    }
    #endregion
}

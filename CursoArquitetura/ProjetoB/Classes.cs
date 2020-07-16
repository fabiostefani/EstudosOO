using ProjetoA;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoB
{
    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            //var privada = new Privada(); //NÃO CONSEGUE PORQUE É PRIVADA. SÓ ESTÁ DISPONÍVEL NO PRÓPRIO ASSEMBLY.
                                         //CONSEGUE TER ACESSO QUANDO VOCÊ EXTENDER O ACESSO DO 'PROJETOA' PARA O ASSEMBLY DO 'PROJETOB' ATRAVÉS DA ANOTAÇÃO '[assembly: InternalsVisibleTo("ProjetoB")]' QUE ESTÁ NO NAMESPACE DA CLASSE.
            //var interna = new Interna(); //NÃO CONSEGUE PORQUE SOMENTE FICA DISPONÍVEL NO MESMO ASSEMBLY.
                                         //CONSEGUE TER ACESSO QUANDO VOCÊ EXTENDER O ACESSO DO 'PROJETOA' PARA O ASSEMBLY DO 'PROJETOB' ATRAVÉS DA ANOTAÇÃO '[assembly: InternalsVisibleTo("ProjetoB")]' QUE ESTÁ NO NAMESPACE DA CLASSE.
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
            //publica.TesteInternal(); //SOMENTE IRÁ CONSEGUIR ACESSAR SE LIBERAR A ANOTAÇÃO DE EXTENSÃO PARA ESSE PROJETO.
            //publica.TesteProtegidoInterno(); //SOMENTE IRÁ CONSEGUIR ACESSAR SE LIBERAR A ANOTAÇÃO DE EXTENSÃO PARA ESSE PROJETO.
            //publica.TesteProtegido(); //NÃO IRÁ CONSEGUIR ACESSAR PQ NÃO TEM HERANÇA.
            //publica.TestePrivadoProtegido(); //NÃO TERÁ ACESSO, PQ SÓ CLASSES QUE HERDAM PODEM ACESSAR
            //publica.TestePrivado(); //PRIVADO NUNCA TERÁ ACESSO
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            //TesteInternal(); //SOMENTE IRÁ CONSEGUIR ACESSAR SE LIBERAR A ANOTAÇÃO DE EXTENSÃO PARA ESSE PROJETO.
            TesteProtegidoInterno();
            TesteProtegido();
            //TestePrivadoProtegido(); //SOMENTE IRÁ CONSEGUIR ACESSAR SE LIBERAR A ANOTAÇÃO DE EXTENSÃO PARA ESSE PROJETO.
            //TestePrivado(); //PRIVADO NUNCA TERÁ ACESSO
        }
    }
}

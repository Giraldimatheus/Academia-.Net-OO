using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_1205
{
    internal class Program
    {

        /*
         -ORIENTACAO A OBJETOS
            -Herança: Sobreescrita
            -Listas e coleções(colecoes sao listas, filas, pilhas, arvores, grafos, hash....)
            _metodos e atributs(instancia/objetos ou classe)
        -Arquivo texto
         - plain text = texto puro; tem o JSON tem tbm o XML;
            - json -> REST
            -xml -> SOAP
            -CSV -> VAMOS VER NESSA AULA
            
         

        -Sistema
            -Backend----------->frontend
            -Backend= BD + regraas negocios -----> Nivel do usuario
        


        MENU:
        CADASTRAR PESSOA(CONTROLE DE DUPLICIDADE)
        LISTAR PESSOA
        PESQUISAR PESSOA(atributo nome como chave de pessoa)
        excluir PESSOA
        SAIR
        opção


        Fazer:
            -CLASSE PESSOA(nome, email, dataNascimento (string))
                -metodo para gerar o email da pessoa automaticamente : sobrenome_nome@ufn.edu.br
            -Lista Pessos
                - ordenação(sort) vai ordenar como, precisa ver isso
            Arquivo
                texto puro -> csv, ou seja, separado por ;
                - vamos trabalhar com streamreader(classe leitor)
                -stramwriter(classe escritora)

        Cadastrar -> nome e data de nascimento -> constroi obejto com email gerado -> jog na lista -> atualiza arquivo CSV
        Listar -> mostrar a lista
        Pesquisar -> percorrer a lista a procura de alguma pessoa
        escluir -> pesquisar -> retirar da lista -> atualizar arquivo

         
         */

        static void Main(string[] args)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            Persistencia.popularArquivoLista("C:\\Users\\mhgir\\source\\repos\\Aula1205\\dados.dat", listaPessoas);

            Persistencia.exibirLista(listaPessoas);
        }
    }
}

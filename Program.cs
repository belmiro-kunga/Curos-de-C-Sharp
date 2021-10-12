using System;

namespace Curos_de_C_Sharp
{
    class Program
    {
        enum cor {Azul = 1, Amarelo, Castalho, Verde}
        enum Opcao {Criar, Deletar, Editar, Listar, Atualizar}

       
        static void Main(string[] args)
        {
         
            //Criar Menu com enum

            Console.WriteLine("Seleciona uma das opções: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");

           
          int index = int.Parse(Console.ReadLine());
          Opcao opcaoSelecionada = (Opcao)index;

          switch(opcaoSelecionada ){
            case Opcao.Criar:
                Console.WriteLine("desejas Criar um Menu");
                break;
            case Opcao.Deletar:
                Console.WriteLine("desejas Deletar um Menu");
                break;
            case Opcao.Editar:
                Console.WriteLine("desejas Editar um Menue");
                break;
            case Opcao.Listar:
                Console.WriteLine("desejasListar um Menu");
                break;
            case Opcao.Atualizar:
                Console.WriteLine("desejas Atualiza um Menu");
                break;
            default:
                Console.WriteLine("Esta Opção não Existe");
                break;
           
            
          }

           Console.WriteLine(opcaoSelecionada);
        
       

        }

    }
}

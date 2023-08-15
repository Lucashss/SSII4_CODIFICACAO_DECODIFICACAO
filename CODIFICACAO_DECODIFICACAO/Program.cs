using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CODIFICACAO_DECODIFICACAO
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            String nome = "";
            int termo;
            int numero = 1;

            Console.WriteLine("**** Olá, seja bem vindo. ****");
            Console.WriteLine();
            Console.WriteLine("Digite a mensagem a ser codificada.");
            nome = Console.ReadLine().ToString();

            while (opcao != 0)
            {

                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("0. Sair\n1. Exibir o código criptografado.\n2. Digitar o código a ser descriptografado.");
                Console.Write("\nDigite a opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine();


                if (opcao == 1)
                {
                    Console.WriteLine("Segue abaixo o codigo criptografado");
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------------");
                    for (int i = 0; i < nome.Length; ++i)
                        {
                            termo = 2;
                            Console.Write((char)(nome[i] + termo));
                            numero += 2;

                        }
                }
                    else
                        if (opcao == 2)
                            {
                                digitar();
                            }
                                else
                                    if (opcao == 0)
                                        {  
                                            sair(); 
                                        }
            }
        }

        private static void sair()
        {
            Console.Clear();
            Console.WriteLine("*** PRESSIONE QUALQUER TECLA PARA FINALIZAR ***");
            Console.ReadKey();
        }

        private static void digitar()
        {
            Manual manual = new Manual();

            Console.WriteLine("Digite o codigo a ser descriptografado");

            manual.nome2 = Console.ReadLine().ToString();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            for (int z = 0; z < manual.nome2.Length; ++z)
            {
                manual.termo2 = 2;
                Console.Write((char)(manual.nome2[z] - manual.termo2));
                manual.numero2 += 2;

            }

        }
    }
}

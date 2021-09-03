using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arquivos;
using calculadora_Aula.FUNÇÕES;
using Calculadora1;
using Calculo;

namespace Menu1
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CALCULADORA2 = 4;

        public static object MemSize { get; private set; }

        public static void Criar()
        {
                

            {
                while (true)
                {
                    string mensagem = "Olá usuário, bem vindo" +
                        "\nDigite a opção desejada e depois aperte o Enter para acessar" +
                        "\n1 - Para ler o TXT" +
                        "\n2 - Para executar a tabuada" +
                        "\n3 - Calcular a média do aluno" +
                        "\n4 - Aperte para acessar a calculadora" +
                        "\n0 - Para sair do programa";
                        
                    Console.WriteLine(mensagem);

                    int valor = int.Parse(Console.ReadLine());

                    if (valor == SAIDA_PROGRAMA)
                    {
                        break;
                    }
                        
                    else if (valor == LER_ARQUIVOS)
                    {
                        Console.WriteLine("========== Opção Ler TXT ===============");
                        Arquivo.Ler(1);
                        Console.WriteLine("\n=============================================\n");
                    }
                    else if (valor == TABUADA)
                    {
                        Console.WriteLine("========== Opção Tabuada ===============");
                        Console.WriteLine("Digite o número que deseja na tabuada");
                        int numero = int.Parse(Console.ReadLine());
                        Tabuada.FuncaoTabuada(numero);
                        Console.WriteLine("\n=============================================\n");
                    }
                    else if (valor == CALCULO_MEDIA)
                    {
                        Console.WriteLine("===========Calcular o valor da media do aluno===========");
                        Media.Aluno();
                        Console.WriteLine("\n=============================================\n");
                    }
                    if (valor == CALCULADORA2)
                    {
                        Console.WriteLine("===========Opção calculadora===========");
                        Calculadora.calculo();
                        Console.WriteLine("\n============================================\n");
                        
                    }
                    
                    else
                    {
                        Console.WriteLine("Opção invalida digite novamente ");
                        Console.WriteLine("\n=============================================\n");
                    }

                }


            }

        }
    }
}

                    




                    




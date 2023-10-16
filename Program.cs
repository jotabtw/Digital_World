using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ListaDeDigiEscolhidos listaDeDigiEscolhidos = new ListaDeDigiEscolhidos();

            int opcoes = 0;
            while (opcoes != 4) 
            { 
            Console.WriteLine("===============================");
            Console.WriteLine("===      Digital World      ===");
            Console.WriteLine("=== 1 - Cadastrar           ===");
            Console.WriteLine("=== 2 - Listar Contas       ===");
            Console.WriteLine("=== 3 - Remover Conta       ===");
            Console.WriteLine("=== 4 - Sair do Sistema     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            opcoes = int.Parse(Console.ReadLine());
                switch (opcoes)
                {
                    case 1:
                        Console.Clear();
                        DigiEscolhido protagonista = new DigiEscolhido();
                        Console.Write("Insira seu nome: ");
                        protagonista.adicionarNome(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Insira sua idade: ");
                        Console.WriteLine(protagonista.adicionarIdade(int.Parse(Console.ReadLine())));
                        Console.Clear();
                        Console.WriteLine("Insira um dos brasões disponíveis: ");

                        foreach (var item in protagonista.brasoesDisponiveis()) 
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine(protagonista.adicionarBrasao(Console.ReadLine().ToLower()));
                        Console.WriteLine(listaDeDigiEscolhidos.adicionarDigiEscolhido(protagonista));
                        Console.ReadLine();
                    break;
                case 2 :
                        Console.Clear();
                        foreach (var item in listaDeDigiEscolhidos.listarDigiEscolhidos())
                        {
                            Console.WriteLine(item);
                        }
                    Console.ReadLine();
                    break;
                case 3 :
                        Console.Clear();
                        Console.Write("Digite o nome do digiEscolhido que deseja remover: ");
                        Console.WriteLine(listaDeDigiEscolhidos.removerDigiEscolhido(Console.ReadLine()));
                        Console.ReadLine();
                    break; 
                case 4 : 
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opcao não implementada.");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}

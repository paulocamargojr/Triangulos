using System;

namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            
            do
            {

                Console.WriteLine("->Insira 1 para verificar o tipo de triangulo \n->Digite 'S' para sair");
                opcao = Console.ReadLine();

                if(opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {

                    break;

                }

                if (opcao == "1")
                {

                    Console.WriteLine("Insira o vertice A do triangulo:");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira o vertice B do triangulo:");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira o vertice C do triangulo:");
                    double c = Convert.ToDouble(Console.ReadLine());

                    if (a < b + c && b < a + c && c < a + b)
                    {

                        if (a == b && b == c)
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("As medidas informadas formam um triangulo eqüilátero");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pressione qualquer tecla");
                            Console.ReadKey();

                        }
                        else if ((a == b && b != c) || (a == c && c != b) || (b == c && c != a))
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("As medidas informadas formam um triangulo isósceles");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pressione qualquer tecla");
                            Console.ReadKey();

                        }
                        else if (a != b && b != c)
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("As medidas informadas formam um triangulo escaleno");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pressione qualquer tecla");
                            Console.ReadKey();

                        }

                    }else if(!(a < b + c && b < a + c && c < a + b))
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("As medidas inseridas não podem formar um triangulo! Tente novamente");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Pressione qualquer tecla");
                        Console.ReadKey();

                    }

                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida! Tente novamente");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Pressione qualquer tecla");
                    Console.ReadKey();

                }

                Console.Clear();

            } while (opcao != "1" || !opcao.Equals("s", StringComparison.OrdinalIgnoreCase));

        }
    }
}

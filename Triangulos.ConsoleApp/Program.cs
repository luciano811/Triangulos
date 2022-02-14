using System;

namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao algoritmo dos Triângulos! Vamos descobrir se ele é escaleno, isóceles ou equilátero\n");

            while (true)
            {
                Console.WriteLine("\nDigite o valor do lado X");

                int x = Convert.ToInt32(Console.ReadLine());
                                               
                Console.WriteLine("\nDigite o valor do lado Y");

                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nDigite o valor do lado Z");

                int z = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nDigite 1 para verificar o tipo do triângulo\nDigite 2 para sair");

                int r = Convert.ToInt32(Console.ReadLine());

                if (r == 1)

                {
                    // Esse if abaixo é necessário para garantir que os valores atendam à condição de definição de triângulo
                    if (x < y + z || y < x + z || z < x + y)
                    {

                        if (x == y && y == z)
                        {
                            Console.Write($"\nSeu triângulo tem os lados: ({x}, {y}, {z})\nSeu Triângulo é equilátero!");
                        }

                        else if (x != y && x != z && z != y)
                        {
                            Console.Write($"\nSeu triângulo tem os lados: ({x}, {y}, {z})\nSeu Triângulo é Escaleno!");
                        }

                        else if (y == x || x == z || y == z)
                        {
                            Console.Write($"\nSeu triângulo tem os lados: ({x}, {y}, {z})\nSeu Triângulo é Isóceles!");
                        }

                        else if (r == 2)
                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Você digitou errado");
                        }

                        Console.WriteLine("\n\n\nDigite 3 para verificar um novo triânulo\nDigite 2 para sair");

                        int t = 0;
                        t = Convert.ToInt32(Console.ReadLine());

                        if (t == 3)
                        {
                            continue;
                        }

                        else if (t == 2)
                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Você digitou errado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não é um triângulo");
                    }
                }              
            }
        }
    }
}

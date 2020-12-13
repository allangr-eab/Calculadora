using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        try
        {
                do
                {
                   Console.Clear();
                   Console.WriteLine("<------Operações------>");
                   Console.WriteLine("Subtrair: -");
                   Console.WriteLine("Somar: +");
                   Console.WriteLine("Dividir: /");
                   Console.WriteLine("Multiplicar: *");
                   Console.WriteLine("Radiação (Raiz Quadrada): R");
                   Console.WriteLine("Potencia: P");
                   Console.WriteLine("Creditos: c\n");
                   Console.Write("Escolha uma das opções acima: ");
                   escolha = Console.ReadLine().ToUpper();

                   if (escolha == "-")
                    {
                        subtracao();
                    }
                    if (escolha == "+")
                    {
                        soma();
                    }

                    if (escolha == "/")
                    {
                        divisao();
                    }

                    if (escolha == "*")
                    {
                        multiplicacao();
                    }

                    if (escolha == "R")
                    {
                        raiz();
                    }

                    if (escolha == "P")
                    {
                        potencia();
                    }

                    if (escolha == "C")
                     {
                        Creditos();
                    }
                     
                    Console.Write("Deseja Sair? S/N: ");
                    sair = Console.ReadLine().ToUpper();
                }
                while (sair != "S" && sair != "SIM");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível dividir por 0.");
                Console.WriteLine("Enter para sair!");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine();
                Console.WriteLine("Número não existe.");
                Console.WriteLine("Enter para sair!");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Número de formato inválido.");
                Console.WriteLine("Enter para sair!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(); 
                Console.WriteLine($"Erro genérico: {ex.Message}");
                Console.WriteLine("Enter para sair!");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Obrigado por ultilizar");
        }

        static void subtracao()
        {
            double x1, x2, resultado;

            Console.Clear();

            Console.Write("Digite o 1ºValor: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºValor: ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = x1 - x2;
            Console.WriteLine($"O resultado de {x1} - {x2} = {resultado}");
            Console.WriteLine();
        }
        static void soma()
        {
            double x1, x2, resultado;

            Console.Clear();

            Console.Write("Digite o 1ºValor: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºValor: ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = x1 + x2;
            Console.WriteLine($"O resultado de {x1} + {x2} = {resultado}");
            Console.WriteLine();
        }
        static void divisao()
        {
            double x1, x2, resultado;

            Console.Clear();

            Console.Write("Digite o 1ºValor: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºValor: ");
            x2 = double.Parse(Console.ReadLine());

            if (x2 == 0)
            {
                throw new DivideByZeroException("Não se pode dividir por 0.");
            }

            Console.WriteLine();
            resultado = x1 / x2;

            Console.WriteLine($"O resultado de {x1} / {x2} = {resultado}");
            Console.WriteLine();
        }
        static void multiplicacao()
        {
            double x1, x2, resultado;

            Console.Clear();

            Console.Write("Digite o 1ºValor: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºValor: ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = x1 * x2;
            Console.WriteLine($"O resultado de {x1} * {x2} = {resultado}");
            Console.WriteLine();
        }
        static void raiz()
        {
            double rQ, resultado;

            Console.Clear();

            Console.Write("Digite o Valor de Raiz Quadrada: ");
            rQ = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = Math.Sqrt(rQ);
            Console.WriteLine($"A raiz quadrada de {rQ} é = {Math.Round(resultado, 2)}");
        }
        static void potencia()
        {
            double x1, x2, resultado;

            Console.Clear();

            Console.Write("Digite o 1ºValor: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºValor: ");
            x2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            resultado = Math.Pow(x1,x2);

            Console.WriteLine($"A Potencia de {x1} elevado a  {x2} é = {resultado}");
            Console.WriteLine();
        }
        static void Creditos()
        {
                    Console.Clear();

                    Console.WriteLine("Escola: Etec Adolpho berezin ");
                    Console.WriteLine("Progamador: Allan Santos");
                    Console.WriteLine("Materia P.C. 1");
                    Console.WriteLine("Projeto final ");
                    Console.WriteLine("Obrigado por testar o programa");
        }
    }
}
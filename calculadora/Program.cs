using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Digite a operação desejada: ");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Limpar terminal");
                Console.WriteLine("6 - Sair");
                Console.WriteLine("==================================================");

                string opcaoUsuario = Console.ReadLine();

                switch(opcaoUsuario)
                {
                    case "1":
                    Console.WriteLine($"O resultado é: {Soma()}");
                    Console.WriteLine("==================================================");
                    break;

                    case "2":
                    Console.WriteLine($"O resultado é: {Subtracao()}");
                    Console.WriteLine("==================================================");
                    break;

                    case "3":
                    Console.WriteLine($"O resultado é: {Multiplicacao()}");
                    Console.WriteLine("==================================================");
                    break;

                    case "4":
                    Console.WriteLine($"O resultado é: {Divisao()}");
                    Console.WriteLine("==================================================");
                    break;

                    case "5":
                    Console.Clear();
                    break;

                    case "6":
                    return;
                }
            }
        }

        public static double Soma()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double b = double.Parse(Console.ReadLine());
            return a + b;
        }
        public static double Subtracao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double b = double.Parse(Console.ReadLine());
            return a - b;
        }

        public static double Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double b = double.Parse(Console.ReadLine());
            return a * b;
        }

        public static double Divisao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double b = double.Parse(Console.ReadLine());
            return a / b;
        }
    }
}
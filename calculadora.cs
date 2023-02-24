using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("C A L C U L A D O R A");

            Console.WriteLine("");

            Console.WriteLine("1 | SOMA");
            Console.WriteLine("2 | SUBTRAÇÃO");
            Console.WriteLine("3 | DIVISÃO");
            Console.WriteLine("4 | MULTIPLICAÇÃO");

            Console.WriteLine("");

            Console.WriteLine("Digite o número correspondente à operação!");
            short resposta = short.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();

            //   INTERAÇÃO COM O USUÁRIO
            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine()); // receber/ler o ítem

            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            //   SOMA DOS NÚMEROS
            float soma = primeiroValor + segundoValor;

            //   RESULTADO
            Console.WriteLine("A soma entre os dois valores é: " + soma);
            Console.ReadKey();

            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            //   INTERAÇÃO COM O USUÁRIO
            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine()); // receber/ler o ítem

            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            //   SUBTRAÇÃO DOS NÚMEROS
            float subtracao = primeiroValor - segundoValor;

            //   RESULTADO
            Console.WriteLine("A subtração entre os dois valores é: " + subtracao);
            Console.ReadKey();

            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            //   INTERAÇÃO COM O USUÁRIO
            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine()); // receber/ler o ítem

            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            //   DIVISÃO DOS NÚMEROS
            float divisao = primeiroValor / segundoValor;

            //   RESULTADO
            Console.WriteLine("A divisão entre os dois valores é: " + divisao);
            Console.ReadKey();

            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            //   INTERAÇÃO COM O USUÁRIO
            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine()); // receber/ler o ítem

            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            //   MULTIPLICAÇÃO DOS NÚMEROS
            float multiplicacao = primeiroValor * segundoValor;

            //   RESULTADO
            Console.WriteLine("A multiplicação entre os dois valores é: " + multiplicacao);
            Console.ReadKey();

            Menu();
        }
    }
}

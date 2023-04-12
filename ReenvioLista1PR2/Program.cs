using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exerciico1
            {
                int metros;

                Console.WriteLine("Insira o valor em metros: ");
                metros = int.Parse(Console.ReadLine());

                Console.WriteLine("A quantidade em centímetros é: " + (metros * 100));
                Console.WriteLine("A quantidade em milímetros é: " + (metros * 1000));
                Console.ReadKey();
            }

            int fahrenheitInt, resultadoInt;
            float fahrenheitFloat, resultadoFloat;

            Console.WriteLine("Entre com o valor inteiro: ");
            fahrenheitInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor float: ");
            fahrenheitFloat = float.Parse(Console.ReadLine());

            resultadoInt = (fahrenheitInt - 32) * (5 / 9);
            resultadoFloat = (fahrenheitFloat - 32.0f) * (5.0f / 9.0f);

            Console.WriteLine("A conversão inteira é " + resultadoInt);
            Console.WriteLine("A conversão float é " + resultadoFloat);
            Console.ReadKey();
        }
        public static void Exercicio3()
        {
            float altura, peso, resultado;

            Console.WriteLine("Insira a sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o seu peso: ");
            peso = float.Parse(Console.ReadLine());

            altura = (altura * altura);
            resultado = (peso / altura);

            Console.WriteLine("O IMC calculado é: " + resultado);
            Console.ReadKey();
        }
        public static void Exercicio4()
        {
            int peso1, peso2, peso3;
            float nota1, nota2, nota3;

            Console.WriteLine("Insira a nota 1: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o peso da nota 1: ");
            peso1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nota 2: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o peso da nota 2: ");
            peso2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nota 3: ");
            nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o peso da nota 3: ");
            peso3 = int.Parse(Console.ReadLine());

            peso1 = peso1 / 10;
            peso2 = peso2 / 10;
            peso3 = peso3 / 10;

            nota1 = nota1 * peso1;
            Console.WriteLine("A nota final obtida na nota 1 é: " + nota1);
            nota2 = nota2 * peso2;
            Console.WriteLine("A nota final obtida na nota 2 é: " + nota2);
            nota3 = nota3 * peso3;
            Console.WriteLine("A nota final obtida na nota 3 é: " + nota3);
            Console.ReadKey();
        }
        public static void Exercicio5()
        {
            int posFinal, posInicial, velocidade, deltaT;

            Console.WriteLine("Entre com a posição inicial em metro: ");
            posInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a velocidade em m/s: ");
            velocidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o delta T em segundos: \n");
            deltaT = int.Parse(Console.ReadLine());

            posFinal = posInicial + velocidade * deltaT;

            Console.WriteLine("A posição final é de {0} metros.", posFinal);
            Console.ReadKey();
        }
        public static void Exercicio6()
        {
            float salario, porcentagem, resultado;

            Console.WriteLine("Insira o salário do funcionário: ");
            salario = float.Parse(Console.ReadLine());

            porcentagem = salario / 100;
            porcentagem = porcentagem * 25;
            resultado = salario + porcentagem;

            Console.WriteLine("O salário atual do funcionário é de: " + resultado);
            Console.ReadKey();
        }
        public static void Exercicio7()
        {
            float real, cotacao, result;

            Console.WriteLine("Insira o valor em REAIS: ");
            real = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a cotação atual do DÓLAR: ");
            cotacao = float.Parse(Console.ReadLine());

            result = real / cotacao;
            Console.WriteLine("A quantidade correspondente à dólares é: ");
            Console.ReadKey();
        }
        public static void Exercicio8()
        {
            int num, sucessor, antecessor, soma;

            Console.WriteLine("Insira um valor inteiro: ");
            num = int.Parse(Console.ReadLine());

            sucessor = num * 3 + 1;
            antecessor = num * 2 - 1;
            soma = antecessor + sucessor;

            Console.WriteLine("O resultado da soma é: ");
            Console.ReadKey();
        }
        public static void Exercicio9()
        {
            int n;
            Console.WriteLine("Entre com um número: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Divisão inteira: " + n / 1000);
            n = n % 1000;
            Console.WriteLine("Divisão inteira: " + n / 100);
            n = n % 100;
            Console.WriteLine("Divisão inteira: " + n / 10);
            Console.WriteLine("Divisão inteira: " + n % 10);
            Console.ReadKey();
        }
        public static void Exercicio10()
        {
            float r1, r2, r3, r4, div;

            Console.WriteLine("O valor inicial de Marquesito é R$1000,00.");

            div = 1000 / 100;
            r1 = div * 3.6f;
            r1 = 1000 - r1;
            Console.WriteLine("Patrimônio caiu 3,4% e resultou em: R$" + r1);

            div = r1 / 100;
            r2 = div * 2.8f;
            r2 = r1 + r2;
            Console.WriteLine("Patrimônio subiu 2,8% e resultou em: R$" + r2);

            div = r2 / 100;
            r3 = div * 14;
            r3 = r2 + r3;
            Console.WriteLine("Patrimônio subiu 14% e resultou em: R$" + r3);

            div = r3 / 100;
            r4 = div * 8.5f;
            r4 = r3 + r4;
            Console.WriteLine("Patrimônio caiu 8,5% e resultou em: R$" + r4);
            Console.ReadKey();
        }
        public static void Exercicio11()
        {
            float N, quadrado, cubo;

            Console.WriteLine("Insira um valor qualquer N: ");
            N = float.Parse(Console.ReadLine());

            quadrado = N * N;
            cubo = N * N * N;

            Console.WriteLine("O valor N ao quadrado é: ");
            Console.WriteLine("O valor N ao cubo é: ");
            Console.ReadKey();
        }
        public static void Exercicio12()
        {
            float h, resultMulher, resultHomem;

            Console.WriteLine("Insira o peso (em kg): ");
            h = float.Parse(Console.ReadLine());

            resultMulher = (62.1f * h) - 44.7f;
            resultHomem = (72.7f * h) - 58f;

            Console.WriteLine("O peso ideal para mulheres é " + resultMulher + "kg.");
            Console.WriteLine("O peso ideal para homens é " + resultHomem + "kg.");
            Console.ReadKey();
        }
        public static void Ex9_1()
        {
            int idade;

            Console.WriteLine("Insira a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 18)
            {
                Console.WriteLine("Você é menor de idade!");
            }
            else if (idade > 18)
            {
                Console.WriteLine("Você é maior de idade!");
            }
            Console.ReadKey();
        }
    }
}
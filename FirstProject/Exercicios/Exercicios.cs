using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FirstProject.Exercicios
{
    internal class Exercicios
    {
        public static void Executar()
        {
            //EXERCICIO 1 - Leia 2 valores inteiros e armazene-os nas variáveis A e B.
            //Efetue a soma de A e B atribuindo o seu resultado na variável X.
            //Imprima X conforme exemplo apresentado abaixo.
            //int A, B, X;
            //Console.WriteLine("Digite o valor de A:");
            //A = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor de B:");
            //B = int.Parse(Console.ReadLine());
            //X = A + B;
            //Console.WriteLine("X = " +  X);
            //-------------------------------------------------------------------
            //EXERCICIOS 2 - A fórmula para calcular a área de uma circunferência
            //é: area = π . raio2. Considerando para este problema que π = 3.14159:
            //double R, Area;
            //double pi = 3.14159;
            //R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Area = pi * R * R;
            //Console.WriteLine("A=" + Area.ToString("F4", CultureInfo.InvariantCulture));
            //-------------------------------------------------------------------
            //EXERCICIO 3 -Leia dois valores inteiros, no caso para variáveis A e B.
            //A seguir, calcule a soma entre elas e atribua à variável SOMA
            //int A, B, SOMA;
            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //SOMA = A + B;
            //Console.WriteLine("SOMA = " + SOMA);
            //-------------------------------------------------------------------
            //EXERCICIO 4 - Leia dois valores inteiros.
            //A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
            //A seguir mostre a variável PROD com mensagem correspondente.  
            //int v1, v2, PROD;
            //v1 = int.Parse(Console.ReadLine());
            //v2 = int.Parse(Console.ReadLine());
            //PROD = v1 * v2;
            //Console.WriteLine("PROD = " + PROD);
            //-------------------------------------------------------------------
            //EXERCICIO 5 -Leia quatro valores inteiros A, B, C e D.
            //A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula:
            //DIFERENCA = (A * B - C * D).
            //int A, B, C, D,DIFERENCA;
            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //C = int.Parse(Console.ReadLine());
            //D = int.Parse(Console.ReadLine());
            //DIFERENCA = (A * B) - (C * D);
            //Console.WriteLine("DIFERENÇA = " + DIFERENCA);
            //-------------------------------------------------------------------
            int numeroDoFuncionario, horasTrabalhadas;
            double valorDaHora,salario;
            numeroDoFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorDaHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = horasTrabalhadas * valorDaHora;
            Console.WriteLine("NUMBER = " + numeroDoFuncionario);
            Console.WriteLine("SALARY = " + salario.ToString("2F", CultureInfo.InvariantCulture));
        }
    }
}

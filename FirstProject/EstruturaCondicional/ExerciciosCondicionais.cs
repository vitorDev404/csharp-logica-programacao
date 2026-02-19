using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FirstProject.EstruturaCondicional
{
    internal class ExerciciosCondicionais
    {
        public static void Executar()
        {
            //Fazer um program para ler duas notas um aluno obteve no 1 e 2 semestre.Em seguida mostrar a nita final que
            //o alnuo obteve no ano juntamente com o texto explicativo. Caso a nota final seja < 60 "REPROVADO"
            double nota1, nota2,media;
            Console.WriteLine("Nota 1: ");
            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Nota 2: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media = nota1 + nota2;
            if (media < 60.0)
            {
                Console.WriteLine("NOTA FINAL = " + media.ToString("F2", CultureInfo.InvariantCulture) + " REPROVADO");
            }
            else 
            {
                Console.WriteLine("NOTA FINAL = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }
            //-------------------------------------------------
            //Fazer um programa para ler 3 numeros inteiros. Em seguida, mostrar qual o menor dentre os 3 numero lidos.
            int n1,n2,n3;
            string[] numeros = Console.ReadLine().Split(' ');
            n1 = int.Parse(numeros[0]);
            n2 = int.Parse(numeros[1]);
            n3 = int.Parse(numeros[2]);
            if (n1 < n2 && n1 < n3) 
            {
                Console.WriteLine("MENOR = " + n1);
            }
            else if (n2 < n1 && n2 < n3) 
            {
                Console.WriteLine("MENOR = " + n2);
            }
            else
            {
                Console.WriteLine("MENOR = " + n3);
            }
            //-------------------------------------------------
            //Uma operadora de telefonia cobra 50 reais por um plano basico que da direitos a 100 minutos de telefone.
            //Cada minuto excedente custa 2 reais. Fazer um programa para ler a quantidade de minutos que uma pessoa
            //Fazer um programa que leia quanto a pessoa vai ter que pagar pelo plano no final do mes.
            int minutos;
            double conta;
            minutos = int.Parse(Console.ReadLine());
            conta = 50.0;
            if (minutos > 100)
            {
                conta = conta + (minutos - 100) * 2.0;
            }
            Console.WriteLine("Valor a pagar: " + conta.ToString("F2", CultureInfo.InvariantCulture));
            //Fazerr um programa para ler um valor inteiro de 1 a 7 representando um dia da semana
            //(1 = domingo, 2 = segunda, etc). Em seguida, mostrar na tela o dia da semana correspondente ao numero lido.
            int dia;
            string diaSemana;
            dia = int.Parse(Console.ReadLine());
        }
    }
}
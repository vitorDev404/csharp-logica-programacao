using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace FirstProject.Vetores
{
    internal class VetoresEMatrizes
    {
        public static void Executar()
        {
            //VETORES
            //Fazer um programa para ler um número inteiro positivo N depois ler N números
            //quaisquer e armazenalos em um vetor.
            //Em seguida, mostrar na tela todos elementos do vetor.
            //int numero;
            //double[] vetor;
            //numero = int.Parse(Console.ReadLine());
            //vetor = new double[numero];
            //for (int i = 0; i < numero; i++)
            //{
            //    vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}
            //for (int i=0; i<numero; i++)
            //{
            //    Console.Write(vetor[i].ToString("F1",CultureInfo.InvariantCulture));
            //}
            //MATRIZES
            //FAZER UM PROGRAMA PARA LER DOIS NUMEROS INTEIROS POSITIVOS M E N,
            //DEPOIS LER UMA MATRIZ DE M LINHAS E N COLUNAS COM NÚMEROS INTEIROS.
            //EM SEGUIDA MOSTRAR NA TELA A MATRIZ DIGITADA.
            int M, N;
            int[,] A;
            N = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());
            A = new int[M, N];
            for (int i=0; i<M; i++)
            {
                string[]s = Console.ReadLine().Split(' ');
                for (int j=0; j < N; j++)
                {
                    A[i,j]=int.Parse(s[j]);
                }
            }
            for (int i=0; i<M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.EstruturasDeRepeticoes
{
    internal class ExerciciosEstrututasDeRepeticao
    {
        public static void Executar()
        {
            //------ESTRUTURA DE REPETICÃO ENQUANTO------
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida.
            //Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
            //Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.
            //Considere que a senha correta é o valor 2002. 
            //int senha = int.Parse(Console.ReadLine());
            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha Invalida");
            //    senha = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Acesso Permitido");
            //-------------------------------------------
            //Crie um programa que:
            //Peça uma 
            //Enquanto a senha estiver errada, continue 
            //Quando acertar, mostre "Acesso permitido"
            //int senhaCriada,senha,usuario;
            //Console.WriteLine("Digite o numero do usuario: ");
            //usuario = int.Parse(Console.ReadLine());
            //Console.WriteLine("Crie uma senha: ");
            //senhaCriada = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Digite a senha para acessar: ");
            //senha = int.Parse(Console.ReadLine());
            //while (senha != senhaCriada)
            //{
            //    Console.WriteLine("Senha Invalida");
            //    senha = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Bem Vindo Usuario " + usuario);
            //-------------------------------------------
            //Média até digitar 0
            //Peça números ao usuário
            //Continue pedindo enquanto ele não digitar 
            //No final, mostre a média dos números digitados
            int numero,contador,soma;
            double media;
            contador = 0;
            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            while (numero != 0)
            {
                Console.WriteLine("Digite outro numero: ");
                numero = int.Parse(Console.ReadLine());
                contador = contador + 1;
                soma = numero + numero;
            }
            media = numero /contador;
            Console.WriteLine("Foram digitados"+ contador +" A media dos numeros digitados é: " + media);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FirstProject._02_EntradaDeDados
{
    internal class EntradaDeDados
    {
        public static void Executar()
        {
            //APRENDENDO SOBRE ENTRADA DE DADOS 1 PELO USUÁRIO
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            //APRENDENDO SOBRE O MÉTODO SPLIT (USADO PARA SEPARAR EM VETORES)
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine("Voce digitou " + frase);
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            //APRENDENDO ENTRADA DE DADOS 2 PELO USUARIO
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Voce digitou o numero: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString(CultureInfo.InvariantCulture));

            //TEMOS QUE GUARDAR AS INFORMAÇOES DA MARIA EM 4 VARIAVEIS DIFERENTES
            //NOME, SEXO, IDADE E ALTURA, TUDO NA MESMA LINHA

            string[] let = Console.ReadLine().Split(' ');
            string name = let[0];
            char gender = char.Parse(let[1]);
            int age = int.Parse(let[2]);
            double height = double.Parse(let[3], CultureInfo.InvariantCulture);
            Console.WriteLine(name);
            Console.WriteLine(gender);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString(CultureInfo.InvariantCulture));

            //EXERCICIO PROPOSTA
            string nomeCompleto = Console.ReadLine();
            int quantidadeDeQuartos = int.Parse(Console.ReadLine());
            float precoDeUmProduto = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] infos = Console.ReadLine().Split(' ');
            string nome = infos[0];
            int idade = int.Parse(infos[1]);
            double altura = double.Parse(infos[2],CultureInfo.InvariantCulture);
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quantidadeDeQuartos);
            Console.WriteLine(precoDeUmProduto.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}

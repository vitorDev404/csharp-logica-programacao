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
            //EXERCICIO 6 - Escreva um programa que leia o número de um funcionário,
            //seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.
            //A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
            //int numeroDoFuncionario, horasTrabalhadas;
            //double valorDaHora,salario;
            //numeroDoFuncionario = int.Parse(Console.ReadLine());
            //horasTrabalhadas = int.Parse(Console.ReadLine());
            //valorDaHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //salario = horasTrabalhadas * valorDaHora;
            //Console.WriteLine("NUMBER = " + numeroDoFuncionario);
            //Console.WriteLine("SALARY = " + salario.ToString("F2", CultureInfo.InvariantCulture));
            //-------------------------------------------------------------------
            //EXERCICIO 7 - Neste problema, deve-se ler o código de uma peça 1, o número de peças 1,
            //o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
            //Após, calcule e mostre o valor a ser pago.
            //int codigoPeca1, numeroPeca1, codigoPeca2, numeroPeca2;
            //double valorPeca1, valorPeca2, valorAPagar;
            //string[] valores = Console.ReadLine().Split(' ');
            //codigoPeca1 = int.Parse(valores[0]);
            //numeroPeca1 = int.Parse(valores[1]);
            //valorPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //valores = Console.ReadLine().Split(' ');
            //codigoPeca2 = int.Parse(valores[0]);
            //numeroPeca2 = int.Parse(valores[1]);
            //valorPeca2 = double.Parse(valores[2],CultureInfo.InvariantCulture);

            //valorAPagar = valorPeca1 *numeroPeca1 + valorPeca2* numeroPeca2;

            //Console.WriteLine("VALOR A PAGAR: R$" + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));
            //-------------------------------------------------------------------
            //EXERCICIO 8 - Calcule o consumo médio de um automóvel
            //sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).
            //int distanciaKm;
            //double gastoLitros, totalCombustivel;
            //distanciaKm = int.Parse(Console.ReadLine());
            //gastoLitros = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //totalCombustivel = distanciaKm / gastoLitros;
            //Console.WriteLine(totalCombustivel.ToString("F3", CultureInfo.InvariantCulture) + "Km/L");
            //-------------------------------------------------------------------
            //EXERCICIO 9 - Dois carros (X e Y) partem em uma mesma direção. O carro X sai com velocidade constante de 60 Km/h e o carro Y sai com velocidade constante de 90 Km/h.
            //Em uma hora(60 minutos) o carro Y consegue se distanciar 30 quilômetros do carro X, ou seja, consegue se afastar um quilômetro a cada 2 minutos.
            //Leia a distância(em Km) e calcule quanto tempo leva(em minutos) para o carro Y tomar essa distância do outro carro.
            //int distancia, tempo;
            //distancia = int.Parse(Console.ReadLine());
            //tempo = distancia * 2;
            //Console.WriteLine(tempo + "minutos");
            //-------------------------------------------------------------------
            //Exercicio 10 - Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, ao utilizar um automóvel que faz 12 KM/L.
            //Para isso, ele gostaria que você o auxiliasse através de um simples programa. Para efetuar o cálculo, deve-se fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h).
            //Assim, pode-se obter distância percorrida e, em seguida, calcular quantos litros seriam necessários. Mostre o valor com 3 casas decimais após o ponto.
            //int tempoGasto, velocidadeMedia, distancia;
            //double quantidadeLitros;
            //tempoGasto = int.Parse(Console.ReadLine());
            //velocidadeMedia = int.Parse(Console.ReadLine());
            //distancia = tempoGasto * velocidadeMedia;
            //quantidadeLitros = distancia / 12.0;
            //Console.WriteLine(quantidadeLitros.ToString("F3",CultureInfo.InvariantCulture));
            //-------------------------------------------------------------------
            //EXCERCICIO 11 (MEDIA PONDERADA) - Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno.
            //A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11).
            //Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
            //double A, B, MEDIA;
            //A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //B  = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
            //MEDIA = ((A * 3.5) + (B * 7.5)) / 11.0;
            //Console.WriteLine("MEDIA" + MEDIA.ToString("F5",CultureInfo.InvariantCulture));
            //-------------------------------------------------------------------
            //EXERCICIO 12 (MEDIA PONDERADA) - Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno.
            //A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5.
            //Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
            //double A,B,C,MEDIA;
            //A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            //C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //MEDIA = ((A*2.0)+(B*3.0)+(C*5.0))/10.0;
            //Console.WriteLine("MEDIA "+ MEDIA.ToString("F1",CultureInfo.InvariantCulture));
            //-------------------------------------------------------------------
            //EXERCICIO 13 - FAZER UM PROGRAMA PARA LER O NOME (APENAS UMA PALAVRA) E IDADE DE DUAS PESSOAS.
            //AO FINAL MOSTRAR UMA MENSAGEM COM OS NOMES E IDAD MEDIA ENTRE AS PESSOAS COM UMA CASA DECIMAL.
            //string nome1, nome2;
            //int idade1, idade2;
            //double idadeMedia;
            //string[] vet;
            //vet = Console.ReadLine().Split(" ");
            //nome1 = vet[0];
            //idade1 = int.Parse (vet[1]);
            //vet = Console.ReadLine().Split(" ");
            //nome2 = vet[0];
            //idade2 = int.Parse(vet[1]);
            //idadeMedia = (double)(idade1 + idade2) / 2.0;
            //Console.WriteLine("A idade media de" + nome1 + "e" + nome2 + "é de " + idadeMedia.ToString("F1",CultureInfo.InvariantCulture));
            //-------------------------------------------------------------------
            //EXERCICIO 14 - Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro).
            //Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.
            //string vendedor;
            //double salarioFixo, totalDeVendas,salarioTotal;
            //vendedor = Console.ReadLine();
            //salarioFixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //totalDeVendas =  double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            //salarioTotal = totalDeVendas * 15.0 / 100 + salarioFixo;
            //Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
            //-------------------------------------------------------------------
            //EXERCICIO 15 - Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R).
            //A fórmula para calcular o volume é: (4/3) * pi * R3.
            //Considere (atribua) para pi o valor 3.14159.
            //double R, volume;
            //R = double.Parse(Console.ReadLine());
            //volume = 4.0/3.0 * 3.14159 * Math.Pow(R, 3);
            //Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
            //-------------------------------------------------------------------
            //EXERCICIO 16 - Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            // a) a área do triângulo retângulo que tem A por base e C por altura.
            ////b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B.
            //e) a área do retângulo que tem lados A e B.
            //double a, b, c, areaTrianguloRetangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
            //string[] vet;
            //vet = Console.ReadLine().Split(' ');
            //a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            //c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            //areaTrianguloRetangulo = (a * c) / 2.0;
            //areaCirculo = 3.14159 * c * c;
            //areaTrapezio = (a + b) * c / 2.0;
            //areaQuadrado = b * b;
            //areaRetangulo = a * b;
            //Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("CIRUCLO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            //-------------------------------------------------------------------
            //EXERCICIO 17 - Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano
            //, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais, segundo a fórmula
            //double x1, y1, x2, y2,distancia;
            //string [] vet;
            //vet = Console.ReadLine().Split(' ');
            //x1 = double.Parse (vet[0], CultureInfo.InvariantCulture);
            //y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            //vet = Console.ReadLine().Split(' ');
            //x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            //distancia = Math.Sqrt(Math.Pow(x2 - x1,2.0) + Math.Pow(y2 - y1,2.0));
            //Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
            //-------------------------------------------------------------------
            //EXERCICIO 18 - LER UM NUMERO EM SEGUNDOS E TRANSFORMAR EM HORAS:MINUTOS:SEGUNDOS
            int numero, horas,resto, minutos, segundos;
            numero = int.Parse(Console.ReadLine());
            horas = numero / 3600;
            resto = numero % 3600;
            minutos = resto / 60;
            segundos = resto % 60;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace FirstProject.FuncoesMatematicasEmCSharp
{
    internal class FuncoesMatematicasEmCSharp
    {
        public static void Executar() 
        {
            //double x = 3.0;
            //double y = 4.0;
            //double z = -5.0;
            //double A, B, C;

            //A = Math.Sqrt(x); // Raiz quadrada de x
            //B = Math.Sqrt(y); // Raiz quadrada de y
            //C = Math.Sqrt(25.0); // Raiz quadrada de 25
            //Console.WriteLine("A raiz quadrada de " + x + " = " + A);
            //Console.WriteLine("A raiz quadrada de " + y + " = " + B);
            //Console.WriteLine("A raiz de 25 é igual a = " + C);

            //A = Math.Pow(x, y); // X elevado a Y
            //B = Math.Pow(x, 2.0); // Y elevado a 2
            //C = Math.Pow(5.0, 2.0); // 5 elevado a 2
            //Console.WriteLine(x + " elevado a " + y + " = " + A);
            //Console.WriteLine(x + " elevado a 2  = " + B);
            //Console.WriteLine("5 elevado a 2  = " + C);

            //A = Math.Abs(y);//Valor absoluto de Y
            //B = Math.Abs(z);//Valor absoluto de Z
            //Console.WriteLine("O valor absoluto de " + y + " = " + A);
            //Console.WriteLine("O valor absoluto de " + z + " = " + B);
            //EXERCICIO - FAZER UM PROGRAMA QUE LEIA A LARGURA E COMPRIMENTO DE UM
            //TERRENO E MOSTRAR A AREA E O VALOR
            //Console.WriteLine("Digite a largura do terreno: ");
            //double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Digite o comprimento do terreno: ");
            //double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double area = largura * comprimento;
            //Console.WriteLine("A area do terreno é de: " + area.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Digite o valor do metro quadrado: ");
            //double valorDoMetroQuardrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double precoTotal = area * valorDoMetroQuardrado;
            //Console.WriteLine("O valor do terreno é de:" + precoTotal.ToString("F2", CultureInfo.InvariantCulture));
            //----------------------------------------------
            double largura, comprimento, area, valorMetroQuadrado, precoTotal;

            largura = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            precoTotal = area * valorMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("TOTAL = " + precoTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

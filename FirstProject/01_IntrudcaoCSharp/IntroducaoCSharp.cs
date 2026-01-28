using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace FirstProject._01_IntrudcaoCSharp
{
    internal class IntroducaoCSharp
    {
        public static void Executar()
        { 
        //APRENDENDO SOBRE VARIAVEIS E TIPOS DE DADOS
        double x = 10.35784;
        int z = 32;
        char gener = 'F';
        int a, b;
        //APRENDENDO COMO ESCREVER NO CONSOLE
        Console.WriteLine(x);
        Console.WriteLine(x.ToString("F4"));
        Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Resultado = " + x); Console.WriteLine("O valor do troco é " + x + " reais");
        Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
        Console.WriteLine("A idade da paciente é " + z + " anos e o sexo dela é " + gener);
        //FAZENDO CONTAS SIMPLES 
        a = 5;
        b = 2 * a;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.ReadLine();
        //EXERCIOCIO DE CALCULO DA AREA DO TRAPEZIO USANDO DOUBLE E FLOAT
        double baseMaior, baseMenor, altura, area;
        baseMaior = 8.0;
        baseMenor = 6.0;
        altura = 5.0;

        area = (baseMenor + baseMaior) / 2.0 * altura;
        Console.WriteLine("A area do trapézio é igual a " + area);
        Console.ReadLine();

        float baseM, baseMn, alt, ar;
        baseM = 8f;
        baseMn = 6f;
        alt = 5f;

        ar = (baseM + baseMn)/2f * alt;
        Console.WriteLine("A ar do trapézio é igual a " + ar);
        Console.ReadLine();
        //COMO TRANSFORMAR UM TIPO DE DADO EM OUTRO
        int n1, n2;
        double resultado;

        n1 = 5;
        n2 = 2;

        resultado = (double) n1 / n2;
        Console.WriteLine(resultado);
        Console.ReadLine();
        }
    }
}

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
        }
    }
}

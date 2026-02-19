using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.EstruturaCondicional
{
    internal class EstruturaCondicional
    {
        public static void Executar()
        {
            //ESTRUTURA CONDICIONAL SIMPLES E COMPOSTA
            int horas;
            Console.WriteLine("Que horas são agora");
            horas = int.Parse(Console.ReadLine());
            if (horas < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (horas <= 18)
            {
                Console.WriteLine("Boa Tarde");
            }
            else 
            {
                Console.WriteLine("Boa Noite");
            }
            //ESTRUTURA  CUMULATIVA 
            int minutos;
            double conta;
            minutos = int.Parse(Console.ReadLine());
            conta = 50.0;
            if (minutos > 100)
            {
                conta = conta + (minutos - 100) * 2.0;
            }
            Console.WriteLine("Valor a pagar: " + conta.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

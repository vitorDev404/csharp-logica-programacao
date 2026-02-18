using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.EstruturaCondicional
{
    internal class EstruturaCondicional
    {
        public static void Executar()
        {
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
        }
    }
}

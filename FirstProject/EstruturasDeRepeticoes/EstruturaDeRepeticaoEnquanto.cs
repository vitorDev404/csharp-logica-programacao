using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.EstruturasDeRepeticoes
{
    internal class EstruturaDeRepeticaoEnquanto
    {
        public static void Executar()
        {
            //ESTRUTURA DE REPETIÇÃO ENQUANTO
            int x, soma;
            x = int.Parse(Console.ReadLine());
            soma = 0;
            while (x != 0)
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("SOMA = " + soma);
        }
    }
}

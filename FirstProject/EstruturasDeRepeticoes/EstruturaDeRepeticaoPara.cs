using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace FirstProject.EstruturasDeRepeticoes
{
    internal class EstruturaDeRepeticaoPara
    {
        public static void Executar()
        {
            int user, createPassword, password, attempt, choice;
            double balance, transfer, deposit;
            attempt = 2;
            balance = 1000.00;
            choice = 0;
            Console.WriteLine("================");
            Console.WriteLine("WELCOME TO BANK");
            Console.WriteLine("================");
            Console.WriteLine("Create your user:");
            user = int.Parse(Console.ReadLine());
            Console.WriteLine("Create your password:");
            createPassword = int.Parse(Console.ReadLine());
            Console.WriteLine("================");
            for (attempt = 3; attempt > 0; attempt--)
            {
                Console.WriteLine("Enter you password: ");
                password = int.Parse(Console.ReadLine());
                if (password == createPassword)
                {
                    Console.WriteLine("Welcome to your account user " + user);
                    while (choice != 4)
                    {
                        Console.WriteLine("============================");
                        Console.WriteLine("What do you want to today: ");
                        Console.WriteLine("1 - Check your balance");
                        Console.WriteLine("2 - Make transfer");
                        Console.WriteLine("3 - Make deposit");
                        Console.WriteLine("4 - Exit");
                        Console.WriteLine("============================");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("BALANCE = $" + balance.ToString("F2", CultureInfo.InvariantCulture));
                                break;
                            case 2:
                                Console.WriteLine("How much do you wnat to transfer? ");
                                transfer = double.Parse(Console.ReadLine());
                                balance = balance - transfer;
                                Console.WriteLine("Transfer successful, your new balance is: $" + balance.ToString("F2", CultureInfo.InvariantCulture));
                                break;
                            case 3:
                                Console.WriteLine("How much you want to deposit? ");
                                deposit = double.Parse(Console.ReadLine());
                                balance = balance + deposit;
                                Console.WriteLine("Deposit sucefull, your new balance is: $" + balance.ToString("F2", CultureInfo.InvariantCulture));
                                break;
                            case 4:
                                Console.WriteLine("Exit");
                                break;
                        }
                    break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect password ! You have " + (attempt - 1) + " attempt");
                }
            }
            if (attempt == 0)
            {
                Console.WriteLine("Your account has been blocked, please contact the bank !");
            }
        }
    }
}

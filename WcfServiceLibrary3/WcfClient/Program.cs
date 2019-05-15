using WcfClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient myClient = new CalculatorClient();
            int operation = 0;
            double value = 0;
            bool quit = true;



            while (quit)
            {
                Console.WriteLine("SuperBank ATM welcomes You.");
                Console.WriteLine("What operation would you like to perform with your account?");
                Console.WriteLine("1 - check balance" +
                "2 - withdraw money from account" +
                "3 - put money to account" +
                "4 - exit");
                operation = Convert.ToInt32(Console.ReadLine());
                if (operation == 1)
                {
                    value = myClient.Show();
                    Console.WriteLine("Your balance is: " + value);
                }

                if (operation == 2)
                {
                    Console.WriteLine("How much money do you want to withdraw?");
                    value = Convert.ToInt32(Console.ReadLine());
                    double result = myClient.Withdraw(value);
                    if (result >= 0)
                    {
                        Console.WriteLine("Your remaining balance is: " + result);

                    }
                    else
                    {
                        Console.WriteLine("Your remaining balance is too low.");
                    }
                }
                if (operation == 3)
                {
                    Console.WriteLine("How much money do you want to deposit?");
                    value = Convert.ToInt32(Console.ReadLine());
                    double result = myClient.Deposit(value);
                    Console.WriteLine("Your balance is " + result);

                }
                if (operation == 4)
                {
                    Console.WriteLine("Goodbye!");
                    quit = false;
                }
            }
            myClient.Close();
        }
    }
}
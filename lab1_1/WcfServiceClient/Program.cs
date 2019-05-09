using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceClient.ServiceReference2;

namespace WcfServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient myClient = new CalculatorClient();
            int intVal,k=1;
            string inpstr,inpcom;
            while (k==1) {
                Console.WriteLine();
                Console.WriteLine("What operation you want to perform?(Withdraw,Deposit,Show balance)");
                inpstr = Console.ReadLine();
                if (inpstr == "Deposit")
                {
                    Console.WriteLine("Insert number to be deposited to account");
                    inpcom = Console.ReadLine();
                    intVal = Convert.ToInt32(inpcom);
                    double result = myClient.Deposit(intVal);
                    Console.WriteLine("Your current balance is equal {0}",result);
                }
                if (inpstr == "Withdraw")
                {
                    Console.WriteLine("Insert value to be withdrawed from your account");
                    inpcom = Console.ReadLine();
                    intVal = Convert.ToInt32(inpcom);
                    double result = myClient.Withdraw(intVal);
                    if (result > 0)
                        Console.WriteLine("Your current balance is equal {0}", result);
                    else
                        Console.WriteLine("Operation cannot be performed");
                }
                if (inpstr == "Show")
                {
                    double result = myClient.Show();
                    Console.WriteLine("Your current balance is equal {0}", result);
                }
                if (inpstr == "Exit")
                {
                    k = 0;
                }
            }
            myClient.Close();
        }
    }
}

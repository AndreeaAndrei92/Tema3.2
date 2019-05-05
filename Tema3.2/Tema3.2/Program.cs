using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check whether a given year is leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());
            leapYear(year);
            int amount = 1000;
            atmTransaction(amount);
            addNumbersFile();




            Console.ReadKey();
        }

        //1-Year is a Leap Year or Not
        public static void leapYear(int year)
        {
            if ((year % 400) == 0)
            {
                Console.WriteLine("{0} is a leap year.\n", year);
            }
            else if ((year % 100) == 0)
            {
                Console.WriteLine("{0} is not a leap year.\n", year);
            }
            else if ((year % 4) == 0)
            {
                Console.WriteLine("{0} is a leap year.\n", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.\n", year);
            }
        }

        //2-ATM Transaction
        public static void atmTransaction(int amount)
        {
            int deposit, withdraw;
            int choice, pin = 0, x = 0;
            Console.WriteLine("Introduceti codul pin");
            pin = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Welcome to ATM Service");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Withdraw Cash");
                Console.WriteLine("3.Deposit Cash");
                Console.WriteLine("4.Quit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your balance is " + amount);
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount to withdraw");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw % 10 != 0)
                        {
                            Console.WriteLine("Please enter the amount in multiples of 10");
                        }
                        else if (withdraw > (amount - 500))
                        {
                            Console.WriteLine("Insufficent balance");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("Please collect cash");
                            Console.WriteLine("Your current balance is " + amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the amount to deposit");
                        deposit = Convert.ToInt32(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("Your balance is " + amount);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using ATM");
                        break;
                }
            }
        }

        //3-Add two numbers in a file
        public static void addNumbersFile()
        {
            string text = File.ReadAllText("F:\\Wantsome\\Cursuri\\Curs 6\\Tema.txt");
            Console.WriteLine($"{text}\n{text[0]}");
            string[] lines = File.ReadAllLines("F:\\Wantsome\\Cursuri\\Curs 6\\Tema.txt");
            double suma = 0;
            foreach (string line in lines)
            {
                suma += Convert.ToDouble(line);
                Console.WriteLine("\t" + line);

            }
            string[] sum = new string[] { Convert.ToString(suma) };
            File.WriteAllLines("F:\\Wantsome\\Cursuri\\Curs 6\\Tema.txt", sum);
            text = File.ReadAllText("F:\\Wantsome\\Cursuri\\Curs 6\\Tema.txt");
            Console.WriteLine($"{text}");
        }

    }
}

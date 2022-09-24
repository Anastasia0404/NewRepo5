using System;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int menu = -1;
            double eur, usd, rub, value = 0;

            Console.Write("Input USD currency > ");
            usd = double.Parse(Console.ReadLine());
            
            Console.Write("Input EUR currency > ");
            eur = double.Parse(Console.ReadLine());
            
            Console.Write("Input RUB currency > ");
            rub = double.Parse(Console.ReadLine());

            Converter converter = new Converter(usd, eur, rub);

            do
            {
                Console.WriteLine("\n\nMenu:\n");
                Console.WriteLine("1) UAH -> USD");
                Console.WriteLine("2) UAH -> EUR");
                Console.WriteLine("3) UAH -> RUB");
                Console.WriteLine("4) USD -> UAH");
                Console.WriteLine("5) EUR -> UAH");
                Console.WriteLine("6) RUB -> UAH");
                Console.Write("0) Exit\n > ");
                menu = int.Parse(Console.ReadLine() ?? "0");

                if (menu != 0)
                {
                    Console.Write("Value > ");
                    value = double.Parse(Console.ReadLine());
                }

                switch (menu)
                { 
                    case 1:
                        Console.WriteLine("Result: " + converter.UahToUsd(value)); 
                        break;        
                    case 2:
                        Console.WriteLine("Result: " + converter.UahToEur(value)); 
                        break;
                    case 3:
                        Console.WriteLine("Result: " + converter.UahToRub(value)); 
                        break;
                    case 4:
                        Console.WriteLine("Result: " + converter.UasToUah(value)); 
                        break;
                    case 5:
                        Console.WriteLine("Result: " + converter.EurToUah(value)); 
                        break;
                    case 6:
                        Console.WriteLine("Result: " + converter.RubToUah(value)); 
                        break;
                }
            } while (menu != 0);
        }
    }
}
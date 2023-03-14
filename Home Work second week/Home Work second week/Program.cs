namespace Home_Work_second_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currencies = { "USD", "EUR", "RUB" };
            decimal[] currencyRates = { 1.78m, 1.82m, 0.02m };

            Console.WriteLine("Aviable commands :");
            Console.WriteLine("/show-currency-rates  ");
            Console.WriteLine("/find-currency-rate-by-code");
            Console.WriteLine("/calculate-amount-by-currecy");
            Console.WriteLine("/Exit");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter command :");
                string command = Console.ReadLine();
                Console.WriteLine();

                if (command == "/show-currency-rates")
                {
                    int idx = 0;
                    while (idx < currencyRates.Length) 
                    {
                        Console.WriteLine($"Currency : {currencies[idx]}, Rate : {currencyRates[idx]}");
                        idx++;
                    }

                }
                else if (command == "/find-currency-rate-by-code")
                {
                    Console.Write("Please enter code :");
                    string specifiedCode = Console.ReadLine();
                    bool isCurrencyExist = false;
                     int idx = 0;

                    while (idx < currencyRates.Length)
                    {
                        string currecnyCode = currencies[idx];
                        decimal curcurrency = currencyRates[idx];
                        if (currecnyCode == specifiedCode)
                        {
                            Console.WriteLine($" Code : {currecnyCode}, Rate : {currencyRates[idx]}");
                            isCurrencyExist = true;
                            break;
                        }

                        idx++;
                    }
                    if (!isCurrencyExist)
                        {
                           Console.WriteLine("Specified code not found");
                        }
                    


                }
                else if (command == "/calculate-amount-by-currecy")
                {

                    Console.Write("Please enter amount in AZN :");
                    decimal amount = decimal.Parse (Console.ReadLine());

                    Console.Write("Please enter code :");
                    string specifiedCode = Console.ReadLine();
                    bool isCurrencyExist = false;
                    int idx = 0;

                    while (idx < currencyRates.Length)
                    {
                        string currecnyCode = currencies[idx];
                        decimal currentCodeRate = currencyRates[idx];   
                        if (currecnyCode == specifiedCode)
                        {
                            Console.WriteLine($"Amount in {currecnyCode}, {amount / currentCodeRate}");
                            isCurrencyExist = true;
                            break;

                        }

                        idx++;

                    }
                    if (!isCurrencyExist)
                    {
                        Console.WriteLine("Specified code not found");
                    }
                }
                else if (command == "/Exit")
                {
                    Console.WriteLine("Thanks for using ");
                    break;
                }
                else
                {
                    Console.WriteLine("Specified command not find");
                }
            }
           
        }
    }
}
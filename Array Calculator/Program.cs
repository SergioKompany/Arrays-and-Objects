using System;

namespace Array_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] array = new string [] {"0", "0", "+", "0", "0", "-", "0", "0", "*", "0", "0", "/"};
            Console.WriteLine("Enter first number:");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            decimal b = decimal.Parse(Console.ReadLine());
            for (int w = 0; w < array.Length; w += 3)
            {
                array[w] = a.ToString();
                array[w+1] = b.ToString();
            }
            decimal [] results = new decimal [4];
            for (int i = 0, k = 0; i < array.Length; i += 3, k++)
            {
                decimal x = decimal.Parse(array[i]);
                decimal y = decimal.Parse(array[i + 1]);
                string sign = array[i + 2];
                if (sign == "+")
                {
                    results[k] = x + y;
                }
                else if (sign == "-")
                {
                    results[k] = x - y;
                }
                else if (sign == "*")
                {
                    results[k] = x * y;
                }
                else if (sign == "/")
                {
                    if (y == 0)
                    {
                        results[k] = int.MaxValue;
                        Console.WriteLine("Divided by zero is infinity, so MaxValue was indicated as the last result instead of it.");
                    }
                    else
                    {
                        results[k] = x / y;
                    }
                }
            }
            Console.WriteLine("The results (+,-,*,/) are:");
            for (int m = 0; m <= results.Length -1; m++)
            {
                if (m < results.Length - 1)
                {
                    Console.Write(results[m] + "; ");
                }
                else
                {
                    Console.Write(results[m] + ".");
                }
            }
            Console.ReadLine();
        }
    }
}

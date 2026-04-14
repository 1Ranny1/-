using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите уравнение");
        string operatorbpl = Console.ReadLine().Replace(" ", "");
        
        foreach (string operation in new[] { "+", "-", "*", "/", "^" })
        {
            int i = operatorbpl.LastIndexOf(operation);
            if (i <= 0)
                continue;
            char op = operatorbpl[i];
            string[]nums = operatorbpl.Split(op);
            string num1Str = nums[0];
            string num2Str = nums[1];
            if(!double.TryParse(num1Str, out var num1) || !double.TryParse(num2Str, out var num2) )
            {
                Console.WriteLine("Было введено не число в одном из чисел");
                break;
            }
            double result = 0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Делить на ноль нельзя");
                        break;
                    }
                    result = num1 / num2;
                    break;
                case '^':
                    result = Math.Pow(num1, num2);
                    break;
            }
            Console.WriteLine($"Результат: {result}");
        }
        Console.ReadLine();
    }
}
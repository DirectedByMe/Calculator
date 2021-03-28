using System;

namespace Calculator
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Вас приветствует простой калькулятор, оперирующий целыми числами.");
            Console.WriteLine("Вы можете сложить, вычесть, умножить и разделить два числа.");
            Console.ReadLine();
            Console.Clear();
            while (true)
            {

                {
                    Console.Clear();
                    int firstValue;
                    int secondValue;
                    string mathAct;

                    try
                    {
                        Console.WriteLine("Введите первое число:");
                        firstValue = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите второе число:");
                        secondValue = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Вы вводите не число! Введите целое число.");
                        Console.ReadLine();
                        continue;
                    }


                    

                    Console.WriteLine("Введите математическое действие (+, -, *, /):");
                    mathAct = Console.ReadLine();

                    switch (mathAct)
                    {
                        case "+":
                            int sum;
                            sum = firstValue + secondValue;
                            Console.WriteLine($"Сумма {firstValue} и {secondValue} = {sum}");
                            break;

                        case "-":
                            int diff;
                            diff = firstValue - secondValue;
                            Console.WriteLine($"Разность {firstValue} и {secondValue} = {diff}");
                            break;

                        case "*":
                            int prod;
                            prod = firstValue * secondValue;
                            Console.WriteLine($"Произведение {firstValue} и {secondValue} = {prod}");
                            break;

                        case "/":
                            if (secondValue == 0)
                            {
                                Console.WriteLine("На ноль делить нельзя!");
                            }
                            else
                            {
                                int quot;
                                quot = firstValue / secondValue;
                                Console.WriteLine($"Частное {firstValue} и {secondValue} = {quot}");
                            }
                            break;

                        default:
                            Console.WriteLine("Вы ввели неверное действие!");
                            break;
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}

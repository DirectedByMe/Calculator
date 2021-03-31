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

                            Console.WriteLine($"Сумма {firstValue} и {secondValue} = " + Addition(firstValue, secondValue));
                            break;

                        case "-":

                            Console.WriteLine($"Разность {firstValue} и {secondValue} = " + Subtraction(firstValue, secondValue));
                            break;

                        case "*":

                            Console.WriteLine($"Произведение {firstValue} и {secondValue} = " + Multiplication(firstValue, secondValue));
                            break;

                        case "/":
                            if (secondValue == 0)
                            {
                                Console.WriteLine("На ноль делить нельзя!");
                            }
                            else
                            {
                                Console.WriteLine($"Частное {firstValue} и {secondValue} = " + Division(firstValue, secondValue));
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

        static private int Addition(int firstValue, int secondValue)
        {
            int sum = firstValue + secondValue;
            return sum;
        }

        static private int Subtraction(int firstValue, int secondValue)
        {
            int sub = firstValue - secondValue;
            return sub;
        }

        static private int Multiplication(int firstValue, int secondValue)
        {
            int prod = firstValue * secondValue;
            return prod;
        }

        static private int Division(int firstValue, int secondValue)
        {
            int quot = firstValue / secondValue;
            return quot;
        }
    }
}

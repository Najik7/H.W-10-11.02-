using System;

namespace H.W_10__11_02_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите знак арифметической операции: + , - , * , /");

            string arithmeticoperation = Console.ReadLine();

            Operation<int> operation;



            switch (arithmeticoperation)
            {
                case "+":
                    operation = Plus;
                    Console.Write($"Сумма двух чисел = ");
                    Console.WriteLine(operation.Invoke(number1, number2));
                    break;
                case "-":
                    operation = Minus;
                    Console.Write($"Разность двух чисел = ");
                    Console.WriteLine(operation.Invoke(number1, number2));
                    break;
                case "*":
                    operation = Multiply;
                    Console.Write($"Частное двух чисел = ");
                    Console.WriteLine(operation.Invoke(number1, number2));
                    break;
                case "/":
                    operation = Division;
                    Console.Write($"Произведение двух чисел = ");
                    Console.WriteLine(operation.Invoke(number1, number2));
                    
                    break;
                default:
                    if (number1 == 0 || number2 == 0)
                        Console.WriteLine("На ноль делить нельзя!!!");
                    else
                    {
                        Console.WriteLine("Ошибка. Введен некорректный символ!!!");
                    }
                    break;
            }

        }


        delegate T Operation<T>(T num1, T num2);

        public static T Plus<T>(T num1, T num2)
        {
            return (dynamic)num1 + (dynamic)num2;
        }

        public static T Minus<T>(T num1, T num2)
        {
            return (dynamic)num1 - (dynamic)num2;
        }

        public static T Multiply<T>(T num1, T num2)
        {
            return (dynamic)num1 * (dynamic)num2;
        }

        public static T Division<T>(T num1, T num2)
        {
            return (dynamic)num1 / (dynamic)num2;
        }


    }
}

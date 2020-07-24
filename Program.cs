using System;
namespace csharp_dotnetcore_calculator
{
    class Program
    {
        public static float add(float first,float second)
        {
            return first + second;//Сложение
        }
        public static float subtraction(float first,float second)
        {
            return first - second;//Вычитание
        }
        public static float multiplication(float first,float second)
        {
            return first * second;
        }
        public static float division(float first,float second)
        {
            return first / second;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");
            while (true)
            {
                Console.WriteLine("Введите первое число:");
                float f = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите операнд(+,-,*,/):");
                string o = Console.ReadLine();
                Console.WriteLine("Введите второе число:");
                float s = float.Parse(Console.ReadLine());

                float result = 0f;

                if (o == "+")
                {
                    result = add(f, s);
                }
                else if(o == "-")
                {
                    result = subtraction(f, s);
                }
                else if(o == "*")
                {
                    result = multiplication(f, s);
                }
                else if(o == "/")
                {
                    result = division(f, s);
                }
                else
                      throw new Exception($"Unexpected operation '{o}'");

                string value = $"Результат: {result}";
                Console.WriteLine(value);




                
            }
        }
    }
}
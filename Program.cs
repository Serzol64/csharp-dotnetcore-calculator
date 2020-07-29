using System;
using System.Threading;
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
            if(second != 0 && first !=0)
            {
                return first / second;
            }
            else{
                return 0;
            }
        }
        public static void MathCalc()
        {
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
        public static void TrigonometryCalc()
        {
            while (true)
            {
                Console.WriteLine("Введите название тригонометрической функции:");
                string o = Console.ReadLine();
                Console.WriteLine("Введите число:");
                double s = double.Parse(Console.ReadLine());

                double result = 0d;

                if (o == "cos")
                {
                    result = Math.Cos(s);
                }
                else if(o == "sin")
                {
                    result = Math.Sin(s);
                }
                else if(o == "tan")
                {
                    result = Math.Tan(s);
                }
                else if(o == "acos")
                {
                    result = Math.Acos(s);
                }
                else if(o == "asin")
                {
                    result = Math.Asin(s);
                }
                else if(o == "atan")
                {
                    result = Math.Atan(s);
                }
                else
                      throw new Exception($"Unexpected operation '{o}'");
                
                string value = $"Результат функции: {result}";
                Console.WriteLine(value);


            }
        }

        public static void NotAvaliable()
        {
            Console.WriteLine("Запрашиваемый вами режим не доступен. Через 10 секунд программа будет закрыта! Просим вас перезапустить программу;-)");
            Thread.Sleep(10000);
            Environment.Exit(0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");

            Console.WriteLine("Введите цифру, включая режим калькулятора(0-традиционный,1-тригонометрический)");

            int mode = int.Parse(Console.ReadLine());

            switch(mode)
            {
                case 0: MathCalc(); break;
                case 1: TrigonometryCalc(); break;
                default: NotAvaliable(); break;
            }
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class IOManager
    {
        private const string ERROR_MESSAGE = "Ошибка: некорректный символ, повторите ввод";

        public void Input2arguments()
        {
            Console.WriteLine("Введите первое число, действие и второе число");
            Console.WriteLine("+ сложение");
            Console.WriteLine("- вычитание из первого числа второго числа");
            Console.WriteLine("* умножение");
            Console.WriteLine("/ деление первого числа на второе");
            Console.WriteLine("^ возведение первого числа в степень - второе число");
            Console.WriteLine("L логарифм первого числа по основанию - второе число");
        }
        public double ReadFirstArgument()
        {
            double x;
            bool isValid = false;
            do
            {
                Console.WriteLine("Введите первое число");
                if (!Double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Ошибка в первом числе, повторите ввод");
                }
                else isValid = true;
            } while (isValid == false);
            return x;
        }

        public char ReadSign(ActionFactory af)
        {
            char sign;
            bool isValid = false;
            do
            {
                Console.WriteLine("Введите знак действия");
                if (Char.TryParse(Console.ReadLine(), out sign) && (af.GetAction(sign) != null))
                {
                    isValid = true;
                }
                else Console.WriteLine("Ошибка в символе, повторите ввод");
            } while (isValid == false);
            return sign;
        }

        public double ReadSecondArgument()
        {
            double y;
            bool isValid = false;
            do
            {
                Console.WriteLine("Введите второе число");
                if (!Double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Ошибка во втором числе, повторите ввод");
                }
                else isValid = true;
            } while (isValid == false);
            return y;
        }

        public bool IsClose()
        {
            char yesOrNo;
            bool isValid = false;
            bool isExit = false;
            do
            {
                Console.WriteLine("Продолжить вычисления? \n Y - Да \n N - Нет");
                if (Char.TryParse(Console.ReadLine(), out yesOrNo))
                {
                    if (yesOrNo == 'Y')
                    {
                        isExit = false;
                        isValid = true;
                    }
                    else if (yesOrNo == 'N')
                    {
                        isExit = true;
                        isValid = true;
                    }
                    else Console.WriteLine(ERROR_MESSAGE);
                }
                else Console.WriteLine(ERROR_MESSAGE);
            } while (isValid == false);
            return isExit;
        }

        public bool IsUseResult()
        {
            char yesOrNo;
            bool isValid = false;
            bool isUse = false;
            do
            {
                Console.WriteLine("Использовать результат в следующем вычислении? \n Y - Да \n N - Нет");
                if (Char.TryParse(Console.ReadLine(), out yesOrNo))
                {
                    if (yesOrNo == 'Y')
                    {
                        isUse = true;
                        isValid = true;
                    }
                    else if (yesOrNo == 'N')
                    {
                        isUse = false;
                        isValid = true;
                    }
                    else Console.WriteLine(ERROR_MESSAGE);
                }
                else Console.WriteLine(ERROR_MESSAGE);
            } while (isValid == false);
            return isUse;
        }

        public bool IsUseFirst()
        {
            char firstOrSecond;
            bool isValid = false;
            bool isUseFirst = false;
            do
            {
                Console.WriteLine("Использовать результат как первое или второе число? \n F - первое \n S - второе");
                if (Char.TryParse(Console.ReadLine(), out firstOrSecond))
                {
                    if (firstOrSecond == 'S')
                    {
                        isUseFirst = false;
                        isValid = true;
                    }
                    else if (firstOrSecond == 'F')
                    {
                        isUseFirst = true;
                        isValid = true;
                    }
                    else Console.WriteLine(ERROR_MESSAGE);
                }
                else Console.WriteLine(ERROR_MESSAGE);
            } while (isValid == false);
            return isUseFirst;
        }
    }
}

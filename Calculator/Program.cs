using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, result = 0;
            char sign;
            bool input2 = true;
            IOManager manager = new IOManager();
            ActionFactory actionFactory = new ActionFactory();
            IAction action;
            while (true)
            {
                if (input2)
                {
                    manager.Input2arguments();
                    x = manager.ReadFirstArgument();
                    sign = manager.ReadSign(actionFactory);
                    y = manager.ReadSecondArgument();
                    action = actionFactory.GetAction(sign);
                    result = action.Calculate(x, y);
                    Console.WriteLine("Результат вычисления = " + result);
                }
                if (manager.IsClose())
                {
                    break;
                }
                else
                if (manager.IsUseResult())
                {
                    input2 = false;
                    if (manager.IsUseFirst())
                    {
                        x = result;
                        sign = manager.ReadSign(actionFactory);
                        y = manager.ReadSecondArgument();
                        action = actionFactory.GetAction(sign);
                        result = action.Calculate(x, y);
                        Console.WriteLine("Результат вычисления = " + result);
                    }
                    else
                    {
                        x = manager.ReadFirstArgument();
                        sign = manager.ReadSign(actionFactory);
                        y = result;
                        action = actionFactory.GetAction(sign);
                        result = action.Calculate(x, y);
                        Console.WriteLine("Результат вычисления = " + result);
                    }
                }
                else
                {
                    input2 = true;
                    continue;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class ActionPower : IAction
    {
        private readonly char sign = '^';
        double IAction.Calculate(double x, double y)
        {
            double result;
            result = Math.Pow(x,y);
            return result;
        }

        char IAction.GetSign()
        {
            return this.sign;
        }
    }
}

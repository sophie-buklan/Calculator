using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class ActionLog : IAction
    {
        private readonly char sign = 'L';
        double IAction.Calculate(double x, double y)
        {
            double result;
            result = Math.Log(x, y);
            return result;
        }

        char IAction.GetSign()
        {
            return this.sign;
        }
    }
}

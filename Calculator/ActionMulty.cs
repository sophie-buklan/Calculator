﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class ActionMulty : IAction
    {
        private readonly char sign = '*';
        double IAction.Calculate(double x, double y)
        {
            double result;
            result = x * y;
            return result;
        }

        char IAction.GetSign()
        {
            return this.sign;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    interface IAction
    {
        double Calculate(double x, double y);
        char GetSign();
    }
}

using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Calculator
{
    class ActionFactory
    {
        ArrayList list = new ArrayList();
        public ActionFactory()
        {
            list.Add(new ActionPlus());
            list.Add(new ActionPlus());
            list.Add(new ActionPlus());
            list.Add(new ActionPlus());
            list.Add(new ActionPlus());
            list.Add(new ActionPlus());
        }

        public IAction GetAction(char sign)
        {
            IAction action=null;
            foreach (IAction i in list)
            {
                if (i.GetSign() == sign)
                    action=i;
            }
            return action;
        }
    }
}

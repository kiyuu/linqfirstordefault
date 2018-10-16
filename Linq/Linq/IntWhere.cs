using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public class IntWhere : Linq
    {
        protected override bool Predicate(object element)
        {
            if (element == null)
            {
                throw new ArgumentException("element is null");
            }

            if (!(element is int))
            {
                throw new ArgumentException("element' type is not integer");
            }


            int i = (int)element;
            return i == 9;
        }
    }
}

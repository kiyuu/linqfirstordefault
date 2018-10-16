using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public class IntWhere : Linq<int>
    {
        protected override bool Predicate(int element)
        {
            return element == 9;
        }
    }
}

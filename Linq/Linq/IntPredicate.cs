using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public class IntPredicate : Predicate<int>
    {
        public bool Predicate(int element)
        {
            return element == 9;
        }
    }
}

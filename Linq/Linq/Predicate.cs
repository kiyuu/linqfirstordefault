using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public interface Predicate<T>
    {
        bool Predicate(T element);
    }
}

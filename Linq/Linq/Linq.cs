using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    public abstract class Linq<T>
    {
        public T FirstOrDefault(T[] source)
        {
            if(source == null)
            {
                throw new ArgumentException("null");
            }

            foreach (var element in source)
            {
                if (this.Predicate(element))
                {
                    return element;
                }
            }

            return default(T);
        }

        protected abstract bool Predicate(T element);

    }
}

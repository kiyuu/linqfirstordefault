using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    public abstract class Linq
    {
        public object FirstOrDefault(object[] source)
        {
            if(source == null)
            {
                throw new ArgumentException("null");
            }

            // 型チェック必要…


            foreach (var element in source)
            {
                if (Predicate(element))
                {
                    return element;
                }
            }

            if (source.All(s => s is int))
            {
                return default(int);
            }
            else if (source.All(s => s is bool))
            {
                return default(bool);
            }
            else if (source.All(s => s is string))
            {
                return default(string[]);
            }
            else
            {
                throw new ArgumentException("type error");
            }
        }

        protected abstract bool Predicate(object element);

    }
}

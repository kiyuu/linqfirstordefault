﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    public static class Linq
    {
        public static T FirstOrDefault<T>(T[] source, Predicate<T> predicate)
        {
            if (source == null)
            {
                throw new ArgumentException("null");
            }

            if(predicate == null)
            {
                throw new ArgumentException("null");
            }

            foreach (var element in source)
            {
                if (predicate.Predicate(element))
                {
                    return element;
                }
            }

            return default(T);
        }
    }
}

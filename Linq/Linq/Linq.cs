using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public class Linq
    {
        public int FirstOrDefault(int[] source)
        {
            foreach(var element in source)
            {
                if(element == 1)
                {
                    return element;
                }
            }
            return default(int);
        }

        public bool FirstOrDefault(bool[] source)
        {
            foreach (var element in source)
            {
                if(element == true)
                {
                    return element;
                }
            }
            return default(bool);
        }

        public string FirstOrDefault(string[] source)
        {
            foreach (var element in source)
            {
                if(element == "aaa")
                {
                    return element;
                }

            }
            return default(string);
        }

        // 型が違う毎に作成………………………………
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LolFactory
{
    class Lolz<T>
    {
        private T[] lolz;
        private int numLolz;

        public Lolz()
        {
            lolz = new T[10];
            numLolz = 0;
        }
 
        public T GetLol(int index)
        {
            return lolz[index];
        }
 
        public void Add(T newLol)
        {
            if (++numLolz == lolz.Length)
            {
                T[] newLolz = new T[lolz.Length * 2];

                for (int index = 0; index < lolz.Length; index++)
                {
                    newLolz[index] = lolz[index];
                }

                lolz = newLolz;
            }

            lolz[numLolz] = newLol;
        }

        public T Pop()
        {
            if (numLolz == 0)
            {
                return default(T);
            }
            return lolz[--numLolz];
        }
    }
}

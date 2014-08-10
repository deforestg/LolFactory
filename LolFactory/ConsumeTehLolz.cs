using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LolFactory
{
    class ConsumeTehLolz
    {
        protected Lolz<string> tehLolz;
        protected object tehLock;

        public ConsumeTehLolz(Lolz<string> lolz, object locker)
        {
            tehLolz = lolz;
            tehLock = locker;
        }

        public void consume()
        {
            while (true)
            {
                string newLol;
                lock (tehLock)
                {
                    newLol = tehLolz.Pop();
                }
                Console.WriteLine(newLol);
            }
        }
    }
}
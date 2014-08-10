using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LolFactory
{
    class ProduceTehLolz
    {
        protected Lolz<string> tehLolz;
        protected object tehLock;
        protected Random lolRandom;

        public ProduceTehLolz(Lolz<string> lolz, object locker)
        {
            tehLolz = lolz;
            tehLock = locker;
            lolRandom = new Random();
        }

        public void produce()
        {
            while (true)
            {
                string newLol = "lol" + lolRandom.Next().ToString();
                lock (tehLock)
                {
                    tehLolz.Add(newLol);
                }
            }
        }
    }
}

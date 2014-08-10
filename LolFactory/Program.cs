using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LolFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Lolz<string> tehLolz = new Lolz<string>();
            object locker = new object();
            ProduceTehLolz producer = new ProduceTehLolz(tehLolz, locker);
            ConsumeTehLolz consumer = new ConsumeTehLolz(tehLolz, locker);
            Thread[] threads = new Thread[2];
            threads[0] = new Thread(producer.produce);
            threads[1] = new Thread(consumer.consume);
            threads[0].Start();
            threads[1].Start();
            threads[0].Join();
            threads[1].Join();
            Console.ReadKey();
        }
    }
}

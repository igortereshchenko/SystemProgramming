using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemProgramming.SyncThread.Mutex
{
    class DecThread
    {
        int num;
        public Thread Thrd;

        public DecThread(string name, int n)
        {
            Thrd = new Thread(new ThreadStart(this.Run));
            num = n;
            Thrd.Name = name;
            Thrd.Start();
        }

        // Точка входа в поток
        void Run()
        {
            Console.WriteLine(Thrd.Name + " waiting mutex");

            // Получить мьютекс
            SharedRes.mtx.WaitOne();

            Console.WriteLine(Thrd.Name + " getting mutex");

            do
            {
                Thread.Sleep(500);
                SharedRes.Count--;
                Console.WriteLine("In thread {0}, Count={1}", Thrd.Name, SharedRes.Count);
                num--;
            } while (num > 0);

            Console.WriteLine(Thrd.Name + " releasing mutex");

            SharedRes.mtx.ReleaseMutex();
        }
    }
}

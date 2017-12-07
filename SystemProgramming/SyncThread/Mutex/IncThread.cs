using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemProgramming.SyncThread.Mutex
{
    class IncThread
    {
        int num;
        public Thread Thrd;

        public IncThread(string name, int n)
        {
            Thrd = new Thread(this.Run);
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

            Console.WriteLine(Thrd.Name + " geting mutex");

            do
            {
                Thread.Sleep(500);
                SharedRes.Count++;
                Console.WriteLine("In thread {0}, Count={1}", Thrd.Name, SharedRes.Count);
                num--;
            } while (num > 0);

            Console.WriteLine(Thrd.Name + " release mutex");

            SharedRes.mtx.ReleaseMutex();
        }
    }
}

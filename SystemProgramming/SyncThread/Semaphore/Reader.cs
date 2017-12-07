using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemProgramming.SyncThread.Semaphore
{
    class Reader
    {

        // создаем семафор
        static System.Threading.Semaphore sem = new System.Threading.Semaphore(3, 3);
        Thread myThread;
        int count = 3;// счетчик чтения

        public Reader(int i)
        {
            myThread = new Thread(Read);
            myThread.Name = "Reader " + i.ToString();
            myThread.Start();
        }

        public void Read()
        {
            while (count > 0)
            {
                sem.WaitOne();

                Console.WriteLine("{0} entered", Thread.CurrentThread.Name);

                Console.WriteLine("{0} reading...", Thread.CurrentThread.Name);
                Thread.Sleep(1000);

                Console.WriteLine("{0} go away", Thread.CurrentThread.Name);

                sem.Release();

                count--;
                Thread.Sleep(1000);
            }
        }
    }
}

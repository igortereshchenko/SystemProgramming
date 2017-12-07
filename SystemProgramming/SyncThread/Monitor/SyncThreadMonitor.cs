using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemProgramming.SyncThread
{
    class SyncThreadMonitor
    {
        static int x = 0;

        static object locker = new object();


        public static void RunFewThreads()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Thread " + i.ToString();
                myThread.Start();
            }

            Console.ReadLine();
        }

        private static void Count()
        {
            try
            {
                Monitor.Enter(locker);
                Console.WriteLine("{0} using X", Thread.CurrentThread.Name);

                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(100);
                }
            }
            finally
            {
                Monitor.Exit(locker);
                Console.WriteLine("{0} releasing  X", Thread.CurrentThread.Name);
            }
        }



    }
}

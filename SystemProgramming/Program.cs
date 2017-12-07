using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SystemProgramming.SyncThread;
using SystemProgramming.SyncThread.Mutex;
using SystemProgramming.SyncThread.Semaphore;

namespace SystemProgramming
{
    class Program
    {
        static void Main(string[] args)
        {

            //ApplicationDomain.DomainInfo();
            Console.Clear();


            //ApplicationDomain.WorkWithDomain();
            Console.Clear();

            //ThreadInfo.SimpleThread();
            Console.Clear();

            //FewThread.StartFewThread();
            Console.Clear();

            //FewThread.StartFewThreadWithParameters();
            Console.Clear();


            //MultyParametersThread.StartMultyParametersThread();
            Console.Clear();

            //MultyParametersThreadBest counter = new MultyParametersThreadBest(1, 4);
            //Thread myThread = new Thread(new ThreadStart(counter.Count));
            //myThread.Start(); 
            Console.Clear();


            //SyncThreadBad.RunFewThreads();
            Console.Clear();

            //SyncThreadBest.RunFewThreads();
            Console.Clear();

            
            //ThreadJoin.Start();
            Console.Clear();


            //SyncThreadMonitor.RunFewThreads();
            Console.Clear();

            //TickTock tt = new TickTock();
            //TickTockThread mt1 = new TickTockThread("Tick", tt);
            //TickTockThread mt2 = new TickTockThread("Tock", tt);
            //mt1.thrd.Join();
            //mt2.thrd.Join();

            //Console.WriteLine("Clock stopped");
            //Console.ReadLine();
            Console.Clear();



            IncThread mt1 = new IncThread("Inc thread", 5);

            // разрешить инкременирующему потоку начаться
            Thread.Sleep(1);

            DecThread mt2 = new DecThread("Dec thread", 5);

            mt1.Thrd.Join();
            mt2.Thrd.Join();

            Console.ReadLine();
            Console.Clear();

            SemaphoreSync.Run();
            Console.Clear();



        }
    }
}

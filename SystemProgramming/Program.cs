using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SystemProgramming.SyncThread;

namespace SystemProgramming
{
    class Program
    {
        static void Main(string[] args)
        {

            ApplicationDomain.DomainInfo();
            Console.Clear();


            ApplicationDomain.WorkWithDomain();
            Console.Clear();

            //ThreadInfo.SimpleThread();
            Console.Clear();

            //FewThread.StartFewThread();
            Console.Clear();

            //FewThread.StartFewThreadWithParameters();
            Console.Clear();


            //MultyParametersThread.StartMultyParametersThread();
            Console.Clear();

            MultyParametersThreadBest counter = new MultyParametersThreadBest(1, 4);
            Thread myThread = new Thread(new ThreadStart(counter.Count));
            //myThread.Start(); 
            Console.Clear();


            //SyncThreadBad.RunFewThreads();
            Console.Clear();

            //SyncThreadBest.RunFewThreads();
            Console.Clear();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemProgramming
{
    class FewThread
    {


        public static void StartFewThread()
        {

            Console.WriteLine("StartFewThread:");


            Thread firstThread = new Thread(new ThreadStart(CountFirst));
            firstThread.Priority = ThreadPriority.Highest;
            firstThread.Start(); // запускаем поток


            Thread secondThread = new Thread(new ThreadStart(CountSecond));
            firstThread.Priority = ThreadPriority.Lowest;
            secondThread.Start(); // запускаем поток
            

            Console.ReadLine();




        }


        public static void StartFewThreadWithParameters()
        {

            Console.WriteLine("StartFewThread:");


            Thread firstThread = new Thread((new ParameterizedThreadStart(CountFirst)));
            firstThread.Start(5); // запускаем поток


            Thread secondThread = new Thread((new ParameterizedThreadStart(CountSecond)));
            secondThread.Start(7); // запускаем поток


            Console.ReadLine();




        }



        private static void CountFirst()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("CountFirst: {0}",i*i);
                //Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }


        private static void CountSecond()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("CountSecond: {0}", i * i);
                //Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }



        private static void CountFirst(object count)
        {
            for (int i = 1; i < (int)count; i++)
            {
                Console.WriteLine("CountFirst: {0}", i * i);
                //Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }


        private static void CountSecond(object count)
        {
            for (int i = 1; i < (int)count; i++)
            {
                Console.WriteLine("CountSecond: {0}", i * i);
                //Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }
    }
}

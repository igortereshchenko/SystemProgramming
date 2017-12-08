using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemProgramming
{
    class ThreadInfo
    {
        public static void SimpleThread()
        {
            // получаем текущий поток
            Thread t = Thread.CurrentThread;

            //получаем имя потока
            Console.WriteLine("Name: {0}", t.Name);
            t.Name = "SimpleThread";
            Console.WriteLine("Name: {0}", t.Name);

            Console.WriteLine("IsAlive: {0}", t.IsAlive);
            Console.WriteLine("Priority: {0}", t.Priority);
            Console.WriteLine("ThreadState: {0}", t.ThreadState);

            // получаем домен приложения
            Console.WriteLine("GetDomain(): {0}", Thread.GetDomain());


            Console.ReadLine();
        }
    }
}

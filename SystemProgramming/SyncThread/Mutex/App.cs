using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming.SyncThread.Mutex
{
    class App
    {
        public static void Run()
        {
            var mutex = new System.Threading.Mutex(false, "MyApp ver 2.0");

            if (!mutex.WaitOne(TimeSpan.FromSeconds(5), false))
            {
                Console.WriteLine("Other instanse is running");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Welcome to MyApp ver 2.0");
            Console.ReadLine();
            mutex.Dispose();
        }

        
    }
}

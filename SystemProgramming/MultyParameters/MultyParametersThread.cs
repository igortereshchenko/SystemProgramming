using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SystemProgramming.MultyParameters;

namespace SystemProgramming
{
    class MultyParametersThread
    {
        public static void StartMultyParametersThread()
        {
            Counter counter = new Counter();
            counter.x = 1;
            counter.y = 5;

            Thread thread = new Thread(new ParameterizedThreadStart(Count));
            thread.Start(counter);

            Console.ReadLine();
 
        }


        private static void Count(object obj)
        {
            Counter counter = (Counter)obj;
            for (int i = counter.x; i < counter.y; i++)
            {
                Console.WriteLine("Count: {0}",i*i);
            }
        }
    }
}

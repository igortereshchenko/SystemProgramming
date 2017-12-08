using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemProgramming.SyncThread.Lock
{
    class MaxFinder
    {
        private object locker = new object();

        
        private int maxThreadElements = 3;

        private List<int> data;
        private List<int> result = new List<int>();

        public MaxFinder(int[] numbers)
        {
            data = new List<int>(numbers);
        }

        public int  FindMax()
        {
      
            do
            {
                result.Clear();

               
                int threadCount = Convert.ToInt32(Math.Ceiling((double)data.Count / maxThreadElements));

                List<int> toSort;
                List<Thread> threads = new List<Thread>();


                for (int i = 0; i < threadCount - 1; i++)
                {
                    toSort = data.GetRange(i * maxThreadElements, maxThreadElements);
                    threads.Add(FindThreadStart(toSort));
                }
                toSort = data.GetRange((threadCount - 1) * maxThreadElements, data.Count - (threadCount - 1) * maxThreadElements);
                threads.Add(FindThreadStart(toSort));


                foreach (Thread _thread in threads)
                    _thread.Join();
            

                data = new List<int>(result);

            } while (result.Count > 1);

            return result[0];
        }


        private Thread FindThreadStart(List<int> toSort)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(FindThread));
            thread.Start(toSort);

            return thread;

        }


        private void FindThread(object list)
        {
            List<int> data = (List<int>)list;

            int max = data[0];
            for (int i = 1; i < data.Count; i++)
                if (max<data[i])
                    max = data[i];

            lock(locker)
            {
                result.Add(max);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming.SyncThread.Mutex
{
    class SharedRes
    {
        public static int Count;
        public static System.Threading.Mutex mtx = new System.Threading.Mutex();
    }
}

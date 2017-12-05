using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SystemProgramming.MultyParameters;

namespace SystemProgramming
{
    class MultyParametersThreadBest
    {

        private int _x;
        private int _y;
        public MultyParametersThreadBest(int x, int y)
        {
            _x = x;
            _y = y;

        }

     

        public void Count()
        {
         
            for (int i = _x; i < _y; i++)
            {
                Console.WriteLine("Count: {0}",i*i);
            }
            Console.ReadLine();
        }
    }
}

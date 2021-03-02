using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingSample
{
    
    class Printer
    {
        object lockToken = new object();
        public void PrintNumbers()
        {

            lock (lockToken)
            {
                //Disolay Tgread Info
                Console.WriteLine("Thread->{0} started @{1} and executing PrintNumbers() method", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToLongTimeString());
                //Print out Numbers
                Console.WriteLine("Your numbers:");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }

        }
    }
}

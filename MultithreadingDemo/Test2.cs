using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingDemo
{
    public class Test2
    {
        public void M1()
        {
            Monitor.Enter(this);
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name);
                    Console.WriteLine(i);
                    // Thread.Sleep(2000);
                }

            }
            Monitor.Pulse(this);
            Monitor.Exit(this);

        }

    }
}

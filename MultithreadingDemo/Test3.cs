using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingDemo
{
    public class Test3
    {
        public void M1()
        {
            Monitor.Enter(this);
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name);
                    Console.WriteLine(i);
                    if (i == 3)
                    {
                        Monitor.Wait(this, 2000);
                    }

                }

            }
            finally
            {
                Monitor.Pulse(this);
                Monitor.Exit(this);
            }


        }

    }
}

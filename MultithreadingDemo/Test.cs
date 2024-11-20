using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingDemo
{
     public class Test
    {
        public void M1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                // Thread.Sleep(2000);
            }
        }
        public void M2()
        {
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine(i);
                //  Thread.Sleep(2000);
                //if (i == 7)
                //{
                //    Thread.ResetAbort();
                //}
            }
        }


    }
}

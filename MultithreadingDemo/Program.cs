using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();
            //// test.M1();
            //// test.M2();
            //Thread t1 = new Thread(new ThreadStart(test.M1));// ThreadStart is a delegate
            //// it will hold method ref that need to exec by the thread
            //Thread t2 = new Thread(new ThreadStart(test.M2));
            //t1.Priority = ThreadPriority.BelowNormal;
            //t2.Priority = ThreadPriority.Highest;

            //t1.Start();
            //t2.Start();
            //t1.Join(); // next all thread will be in wait state to complete the task of t1 thread
            //t2.Join();





            //Test1 test1 = new Test1();
            //Thread t1 = new Thread(new ThreadStart(test1.M1));
            //Thread t2 = new Thread(new ThreadStart(test1.M1));
            //t1.Name = "T1";
            //t2.Name = "T2";
            //t1.Start();
            //t2.Start();




            //Test2 test2 = new Test2();
            //Thread t1 = new Thread(new ThreadStart(test2.M1));
            //Thread t2 = new Thread(new ThreadStart(test2.M1));
            //t1.Name = "T1";
            //t2.Name = "T2";
            //t1.Start();
            //t2.Start();





            Test3 test3 = new Test3();
            Thread t1 = new Thread(new ThreadStart(test3.M1));
            Thread t2 = new Thread(new ThreadStart(test3.M1));
            t1.Name = "T1";
            t2.Name = "T2";
            t1.Start();
            t2.Start();



        }
    }
}

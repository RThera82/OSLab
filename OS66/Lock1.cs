using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Seesion6
{
    internal class Program
    {
        static object lockObj = new object();
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(DoWork);
            Thread thread2 = new Thread(DoWork);
            Console.Write(thread1.ToString());
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine("Both threads have finished excuting");
            Console.ReadKey();
        }

        static void DoWork()
        {
            lock (lockObj)
            {
   

                Console.WriteLine(Thread.CurrentThread.Name + " is entering the critical section.");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " is leaving the critical section.");
            }
        }
    }
}

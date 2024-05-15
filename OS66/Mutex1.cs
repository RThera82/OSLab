using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Mutex6
{
    internal class Program
    {
        private static Mutex mut = new Mutex();
        private const int numIteration = 1;
        private const int numThreads = 3;
        static void Main(string[] args)
        {
            for(int i = 0; i < numThreads; i++)
            {
                Thread newThread = new Thread(new ThreadStart(ThreadProc));
                newThread.Name = String.Format("Thread{0}", i + 1);
                newThread.Start();
                Console.ReadKey();
            }

        }

        private static void ThreadProc()
        {
            for (int i = 0; i < numIteration; i++)
                UseResource();
        }
        private static void UseResource()
        {
            Console.WriteLine("{0} is requesting the mutex",
                              Thread.CurrentThread.Name);
            mut.WaitOne();

            Console.WriteLine("{0} has entered the protected area",
                              Thread.CurrentThread.Name);

            Thread.Sleep(500);

            Console.WriteLine("{0} is leaving the protected area",
                Thread.CurrentThread.Name);
            mut.ReleaseMutex();
            Console.WriteLine("{0} has released the mutex",
                Thread.CurrentThread.Name);
        }
    }
}

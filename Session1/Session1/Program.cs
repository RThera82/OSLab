using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number between 1 to 4:");
            int state = int.Parse(Console.ReadLine());
            Process[] plist = Process.GetProcesses();
            if(state == 1)
            {
                Console.WriteLine("Please enter the process name that you want to start:");
                String name = Console.ReadLine();
                Process.Start(name);
            }
            else if ( state == 2)
            {
                Console.WriteLine("The process list:");
                foreach (Process p in plist)
                    Console.WriteLine(p.Id + "\t" + p.ProcessName);
                
            }
            else if( state == 3)
            {
                Console.WriteLine("Please enter the name of process that you want kill:");
                String name0 = Console.ReadLine();
                foreach(Process p in plist)
                    if (p.ProcessName ==name0)
                        p.Kill();
               
            }
           
            else if(state == 4)
            {
                Console.WriteLine("Please enter the name of process:");
                String child = Console.ReadLine();
                foreach (Process p in plist)
                    if (p.ProcessName == child)
                    {
                        Console.WriteLine("The parent process is:"+p.Handle);
                        

                    }
            }
            
            Console.ReadKey();
            
        }
       
       
    }
}

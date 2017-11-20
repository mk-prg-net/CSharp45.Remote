using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new System.ServiceModel.ServiceHost(typeof(WcfServiceLibrary1.Service1));
            Console.WriteLine("Service gestartet. Mit Enter beenden...");
            Console.ReadLine();

        }
    }
}

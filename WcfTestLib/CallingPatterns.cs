using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTestLib
{
    
    /// <summary>
    /// Methoden zum Testen von Aufruf- Mustern wie synchron/Asynchron sowie zum Test der 
    /// Laufzeiteffizienz verschiedener Bindings
    /// </summary>
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class CallingPatterns : ICallingPatterns, IDisposable
    {

        DateTime ICallingPatterns.DelayedReturn(int delayInMs)
        {
            System.Threading.Thread.Sleep(delayInMs);
            return DateTime.Now;
        }

        long fastCounterValue = 0;
        bool fastCounterRunning = true;

        void FastCounter()
        {
            while (fastCounterRunning)
            {
                System.Threading.Interlocked.Increment(ref fastCounterValue);
            }
        }

        System.Threading.Thread CounterThread;

         void ICallingPatterns.StartFastAsyncCounter()
        {
            fastCounterRunning = true;
            if (CounterThread == null || CounterThread.ThreadState != System.Threading.ThreadState.Running)
            {
                CounterThread = new System.Threading.Thread(new System.Threading.ThreadStart(FastCounter));
                CounterThread.Priority = System.Threading.ThreadPriority.Lowest;
                CounterThread.Start();
            }
            else throw new Exception("Ein CounterThread war bereits gestartet");
        }

        void ICallingPatterns.StopFastAsyncCounter()
        {
            fastCounterRunning = false;
            CounterThread.Join();            
        }

        void ICallingPatterns.ResetFastAsyncCounter()
        {
            ICallingPatterns icp = this;
            icp.StopFastAsyncCounter();
            fastCounterValue = 0;
            icp.StartFastAsyncCounter();
        }

        long ICallingPatterns.GetFastAsyncCounterValue()
        {
            return System.Threading.Interlocked.Read(ref fastCounterValue);
        }

        void IDisposable.Dispose()
        {
            if (CounterThread != null && CounterThread.ThreadState != System.Threading.ThreadState.Running)
            {
                // Beenden des Zählerthreads 
                fastCounterRunning = false;
                CounterThread.Join();   
            }
        }
    }
}

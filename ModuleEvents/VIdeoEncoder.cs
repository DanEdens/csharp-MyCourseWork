using System;
using System.Threading;

namespace ModuleEvents
{ 
    public class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(1000);
        }
    }
}
using System;
using System.Threading;

namespace ModuleEvents
{ 
    public class VideoEncoder
    {
        // 1- define a delegate
        // 2- define an event
        // 3- Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(1000);
            
            OnVideoEncdoed();
        }

        protected virtual void OnVideoEncdoed()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
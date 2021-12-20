using System;
using System.Threading;

namespace _043Events
{


   


    public class VideoEncoder
    {

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }





        //To use an event, you have 3 steps to follow
        //1- Define a delegate : Agreement between the publisher and subscriber. 
        //2- Define an event based on that delegate 
        //3- Raise the event : publish the event


        //1-) object : source of the event, args: any additional data we want to send with event
        // name of our event : VideoEncoded + name of the delegate : EventHandler = VideoEncodedEventHandler
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //2-)Define an event
        public event VideoEncodedEventHandler VideoEncoded;

        //3-)Raise the event
        //Event publisher should be protected, virtual and void..
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty); //we dont have any additional info EventArgs.Empty
            }
        }
        //we will call this event





    }
}
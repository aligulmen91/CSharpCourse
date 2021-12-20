using System;

namespace _043Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MessageService : Sending a text message");
        }
    }

}








/*
 Events : 
a mechanism for communication between objects
Used in building Loosely Coupled Applications
Help extending applications


An example,
we are encoding videos and at the end of encoding we will send a mail to customer
we create it

public void Encode(Video video){

//.....encoding logic

_mailService.Send(new Mail());

}



good but what if we want to send sms too? another line of code
_messageService.Send(new Text());
but we touch this class every time and we should recompile it everytime , this is not good.
So, lets make the classes like blackbox and not sending mails, texts here.
we will call another event : 

OnVideoEncoded();

Now, this class doesn't know and doesn't care about whats happening to sms or mail.. it just finishes its job.

this is how we create events :
public void OnVideoEncoded(object source, EventArgs e)
{
}

we will create all of them inside VideoEncoder.cs because it is going to work there

 */
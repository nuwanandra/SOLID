using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_And_DIP
{


    public interface IMessage
    {

        public void SendMessage(string message, string sender, string recepient);


    }


    public class SMS : IMessage
    {
        public void SendMessage(string message, string sender, string recepient)
        {
            Console.WriteLine("Send Message SMS");

        }

    }

    public class Email: IMessage
    {
        public void SendMessage(string message, string sender, string recepient)
        {
            Console.WriteLine("Send Message Email");
        }

    }


    
    // High-level module (business logic) depending on abstraction
    //Liscov Substitution
    public class NotificationService
    {
        private readonly IMessage _messageSender;

        // Constructor injection of the abstraction
        public NotificationService(IMessage messageSender)
        {
            _messageSender = messageSender;
        }

        public void Notify(string message, string sender, string recepient)
        {
            // Business logic
            //Console.WriteLine("Performing additional logic before notification...");

            // Using the abstraction without knowing the concrete implementation
            _messageSender.SendMessage(message, sender, recepient);

            // Business logic
            //Console.WriteLine("Performing additional logic after notification...");
        }
    }



    //Liscov Substitution
    //public class Client
    //{
    //    IMessage iSender;
    //    public void sendMessage(string message, string sender, string recepient)
    //    {
    //        iSender = new Email();
    //        iSender.SendMessage(message, sender, recepient);

    //        iSender = new SMS();
    //        iSender.SendMessage(message, sender, recepient);


    //    }
    //}

}

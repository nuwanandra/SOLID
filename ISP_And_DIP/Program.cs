// See https://aka.ms/new-console-template for more information
using ISP_And_DIP;

Console.WriteLine("Hello, World!");


IMessage emailSender = new Email();
IMessage smsSender = new SMS();
NotificationService emailService = new NotificationService(emailSender);
NotificationService smsService = new NotificationService(smsSender);



emailService.Notify("a","a","a");
smsService.Notify("a", "a", "a");


emailService.Notify("b", "b", "b");
smsService.Notify("b", "b", "b");


emailService.Notify("c", "c", "c");
smsService.Notify("d", "d", "d");


//Client client = new Client();

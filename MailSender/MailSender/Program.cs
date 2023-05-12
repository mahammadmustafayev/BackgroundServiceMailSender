

using System.Net;
using System.Net.Mail;

namespace MailSender;

internal class Program
{
    static  void Main(string[] args)
    {
        //await new HostBuilder()
        //    .ConfigureServices((hostcontext, services) =>
        //    {
        //        services.AddHostedService<BackgroundWorker>();
        //    }).RunConsoleAsync();

        Console.WriteLine("Mail addressini daxil edin:");
        string mailAddress = Console.ReadLine();
        Console.WriteLine("Mail basliqini daxil edin:");
        string title = Console.ReadLine();
        Console.WriteLine("Gondermek istediyiniz melumati daxil edin");
        string message = Console.ReadLine();
        Console.WriteLine("Email Sending...");
        var smtpClient = new SmtpClient("smtp.office365.com")
        {
            Port = 587,
            Credentials = new NetworkCredential(EmailConfig.email, EmailConfig.password),
            EnableSsl = true,
        };

        smtpClient.Send(EmailConfig.email, mailAddress, title, message);
        Console.WriteLine("Email sent");
    }
}
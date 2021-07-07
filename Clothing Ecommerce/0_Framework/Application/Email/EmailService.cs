using MimeKit;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace _0_Framework.Application.Email
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string title, string messageBody, string destination)
        {
            var message = new MimeMessage();

            var from = new MailboxAddress("Alireza", "alirezapakravan111@gmail.com");
            message.From.Add(from);

            var to = new MailboxAddress("User", destination);
            message.To.Add(to);

            message.Subject = title;
            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = $"<h1>{messageBody}</h1>",
            };

            message.Body = bodyBuilder.ToMessageBody();

            var client = new SmtpClient();
            client.Connect("localhost", 5001, false);
            client.Authenticate("alirezapakravan111@gmail.com", "Alireza1234509876");
            client.Send(message);
            client.Disconnect(true);
            client.Dispose();
        }
    }
}
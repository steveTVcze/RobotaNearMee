using MimeKit;
using RobotaNearMe.Data;
using RobotaNearMe.Lib.Modelos;

namespace RobotaNearMe.Services
{
    public class MailService
    {
        public void NewsletterEveryone(List<Data.User> users, string subject, string messageo)
        {
            foreach (var item in users)
            {
                MimeMessage message = new();
                if (MailboxAddress.TryParse($"{item.Contact.Email}", out var emailAddress))
                {
                    message.To.Add((MailboxAddress)emailAddress);
                    message.Cc.Add(new MailboxAddress("KybernaJeLepsiJakDelta", "hornyondrej@seznam.cz"));
                    message.From.Add(new MailboxAddress("Robota Near Me", "hornyondrej@seznam.cz"));

                    message.Subject = $"{subject}";
                    message.Body = new TextPart("plain")
                    {
                        Text = $"Hello {item.Name} {item.Surname},\n {messageo}\n \n Jan Novák \n Robota near me",
                    };
                    try
                    {
                        MailKit.Net.Smtp.SmtpClient client = new();
                        client.Connect("smtp.seznam.cz", 465, true);
                        client.Authenticate("hornyondrej@seznam.cz", "Heslo1234.");
                        client.Send(message);
                    }
                    catch
                    {

                    }
                }

            }
            
        }
    }
}

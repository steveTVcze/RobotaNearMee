using MimeKit;
using RobotaNearMe.Lib.Modelos;

namespace RobotaNearMe.Client.Services
{
    public class MailService
    {
        public void SendMailToEmail(User _user, string subject, string messageo)
        {
            MimeMessage message = new();
            if (MailboxAddress.TryParse($"{_user.Contact.Email}", out var emailAddress))
            {
                message.To.Add((MailboxAddress)emailAddress);
                message.Cc.Add(new MailboxAddress("KybernaJeLepsiJakDelta", "hornyondrej@seznam.cz"));
                message.From.Add(new MailboxAddress("Robota Near Me", "hornyondrej@seznam.cz"));

                message.Subject = $"{subject}";
                message.Body = new TextPart("plain")
                {
                    Text = $"Hello {_user.Name} {_user.Surname},\n {messageo}\n {message} \n Jan Novák \n Robota near me",
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
        public void SendToSomeoneFromCompany(User _user, string subject, string messageo, CompanyReal company)
        {
            MimeMessage message = new();
            if (MailboxAddress.TryParse($"{_user.Contact.Email}", out var emailAddress))
            {
                message.To.Add((MailboxAddress)emailAddress);
                message.Cc.Add(new MailboxAddress("KybernaJeLepsiJakDelta", "hornyondrej@seznam.cz"));
                message.From.Add(new MailboxAddress("Robota Near Me", "hornyondrej@seznam.cz"));

                message.Subject = $"{subject}";
                message.Body = new TextPart("plain")
                {
                    Text = $"Hello {_user.Name} {_user.Surname} {company.Name} sent you a mail:,\n {messageo} \n \n {company.Name} {company.Admin.Name} {company.Admin.Surname} \n via Robota near me",
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
        public void SendConfirmationMail(string mail, string subject, string messageo)
        {
            MimeMessage message = new();
            if (MailboxAddress.TryParse($"{mail}", out var emailAddress))
            {
                message.To.Add((MailboxAddress)emailAddress);
                message.Cc.Add(new MailboxAddress("KybernaJeLepsiJakDelta", "hornyondrej@seznam.cz"));
                message.From.Add(new MailboxAddress("Robota Near Me", "hornyondrej@seznam.cz"));

                message.Subject = $"{subject}";
                message.Body = new TextPart("plain")
                {
                    Text = $"Hello,\n {messageo} \n Jan Novák \n Robota near me",
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

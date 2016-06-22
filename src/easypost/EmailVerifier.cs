using System;
using System.Net.Mail;
using System.Configuration;

namespace easypost
{
    public class EmailVerifier
    {
        public string Host;

        public EmailVerifier (string host)
        {
            Host = host;
        }

        public void SendVerificationEmail(string emailAddress, string folderId)
        {
            var fromAddress = ConfigurationSettings.AppSettings["EmailAddress"];
            var smtpServer  = ConfigurationSettings.AppSettings["SmtpServer"];

            var subject = CreateSubject ();
            var body = CreateBody (emailAddress, folderId);

            MailMessage mail = new MailMessage(fromAddress, emailAddress);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = smtpServer;
            mail.Subject = subject;
            mail.Body = body;
            client.Send(mail);
        }

        public string CreateSubject()
        {
            return @"easypost - Please verify";
        }

        public string CreateBody(string emailAddress, string folderId)
        {
            return @"Please verify your email address by opening the link below in your web browser:

            " + CreateVerificationLink (emailAddress, folderId);
        }

        public string CreateVerificationLink(string emailAddress, string folderId)
        {
            return String.Format (
                "http://{0}/Verify.aspx?email={1}&folder={2}",
                Host,
                emailAddress,
                folderId
            );
        }
    }
}


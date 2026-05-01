using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace MovieManagementSystem.Services
{
    internal class EmailService
    {
        public void SendVerificationEmail(string recipientEmail, string userName, string code)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Movie System", "chkhetianisandro@gmail.com"));
            message.To.Add(new MailboxAddress(userName, recipientEmail));
            message.Subject = "Verification Code";

            message.Body = new TextPart("plain")
            {
                // Personalized message
                Text = $"Hello {userName},\n\nYour random verification code is: {code}"
            };

            using var client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                client.Authenticate("chkhetianisandro@gmail.com", "dltqegnczprxxlgk");
                client.Send(message);
                client.Disconnect(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[SYSTEM ERROR] {ex.Message}");
                Console.WriteLine($"[DEBUG] Name: {userName}, Code: {code}");
            }
        }
    }
}
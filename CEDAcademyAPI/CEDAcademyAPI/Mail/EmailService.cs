using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace CEDAcademyAPI.Mail
{
    public class EmailService : IIdentityMessageService
    {
        public async Task SendAsync(IdentityMessage message)
        {
            await Task.Run(() => ConfigEmail(message));
        }

        private void ConfigEmail(IdentityMessage message)
        {
            var mail = new MailMessage("ymezghani@gmail.com",
                                       message.Destination,
                                       message.Subject,
                                       message.Body);

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential("ymezghani@gmail.com", "bayezit1994"),


            };
            client.Send(mail);




        }
    }
}
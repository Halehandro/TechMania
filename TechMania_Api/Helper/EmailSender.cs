using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechMania_Api.Helper
{
    public class EmailSender : IEmailSender
    {
        private readonly MailJetSettings _mailJetSettings;

        public EmailSender(IOptions<MailJetSettings> mailjetSettings)
        {
            _mailJetSettings = mailjetSettings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailjetClient client = new MailjetClient(_mailJetSettings.PublicKey, _mailJetSettings.PrivateKey);
            if (subject.Contains("Order Confirmed - TechMania"))
            {
                MailjetRequest request = new MailjetRequest
                {
                    Resource = SendV31.Resource,
                }
               .Property(Send.Messages, new JArray {
                new JObject {
                 {"From", new JObject {
                  {"Email", _mailJetSettings.Email},
                  {"Name", "Techmania"}
                  }},
                 {"To", new JArray {
                  new JObject {
                   {"Email", email},
                   {"Name", email}
                   }
                  }},
                 {"Subject", subject},
                 {"HTMLPart", htmlMessage}
                 }
                   });
                MailjetResponse response = await client.PostAsync(request);
            }
            else
            {
                MailjetRequest request = new MailjetRequest
                {
                    Resource = SendV31.Resource,
                }
               .Property(Send.Messages, new JArray {
                new JObject {
                 {"From", new JObject {
                  {"Email", _mailJetSettings.Email2},
                  {"Name", _mailJetSettings.Email2}
                  }},
                 {"To", new JArray {
                  new JObject {
                   {"Email",_mailJetSettings.Email},
                   {"Name", _mailJetSettings.Email}
                   }
                  }},
                 {"Subject", subject},
                 {"HTMLPart", htmlMessage}
                 }
                   });
                MailjetResponse response = await client.PostAsync(request);
            }


        }


    }
}

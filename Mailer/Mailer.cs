using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mailer
{
    public class Mailer :IMailer
    {
        private ISMTP _smtp;
        public Mailer(ISMTP smtp)
        {
            _smtp = smtp;
        }

        public async void Send(string email)
        {
            await  _smtp.Connect();
            Console.WriteLine($"[To:{email}]");
            Console.WriteLine("Mail Sending....");

            await Task.Delay(2000);

            Console.WriteLine("Mail Sent");
        }
    }

    public interface IMailer
    {
        void Send(string email);
    }


}

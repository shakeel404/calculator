using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mailer
{
    public class SMTP : ISMTP
    {
        public async Task Connect()
        {
            Console.WriteLine("[SMTP]Connecting...");
           await Task.Delay(2000);
            Console.WriteLine("[SMTP]Connected");

        }
    }

    public class SMTPLocal : ISMTP
    {
        public async Task Connect()
        {
            Console.WriteLine("[SMTP Local]Connecting...");
            await Task.Delay(2000);
            Console.WriteLine("[SMTP Local]Connected");

        }
    }
    public interface ISMTP
    {
        Task Connect();
    }
}

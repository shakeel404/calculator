using System;
using System.Collections.Generic;
using System.Text;

namespace Mailer
{
    public class Person : IPerson
    {
        private IMailer _mailer;
        public Person(IMailer mailer)
        {
            _mailer = mailer;
        }

       public string Name { get; set; }
       public int Age { get; set; }
        public string Email => $"{Name}@gmail.com";

        public void SendEmail()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException("Email not found");

            _mailer.Send(Email);
        }
    }

    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        string Email { get; }
        void SendEmail();
    }
}

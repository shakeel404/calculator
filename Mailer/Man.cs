using System;
using System.Collections.Generic;
using System.Text;

namespace Mailer
{
   public class Man
    {
        private IPerson _person;
        public Man(IPerson person)
        {
            _person = person;
        }

        public void SendMail()
        {
            Console.WriteLine($"{_person.Name} is a Man");
            _person.SendEmail();
        }
    }

    public class Woman
    {
        private IPerson _person;
        public Woman(IPerson person)
        {
            _person = person;
        }

        public void SendMail()
        {
            Console.WriteLine($"{_person.Name} is a Woman");

            _person.SendEmail();
        }
    }
}

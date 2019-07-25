using System;
using System.Linq;
using Autofac;
namespace Mailer
{
    class Program
    {
        static void Main(string[] args)
        {
            var bootstraper = new BootStraper();
            var container = bootstraper.BootStrap();

            var person = container.Resolve<Person>();
            person.Name = "Shakeel";
            person.Age = 23;

            var man = new Man(person);
            man.SendMail();
            Console.WriteLine("-------------------------------------");

            person.Name = "Shaheen";

            var woman = new Woman(person);
            woman.SendMail();

            //var numbers = new[]{1,2,3,4,5 };

            //var item = numbers.Aggregate((a, b) => a * b);

            //Console.WriteLine(item);

            Console.ReadLine();
        }
    }

    class BootStraper
    {
        public IContainer BootStrap()
        {
            var container = new ContainerBuilder();

            container.RegisterType<Person>().AsSelf();
            container.RegisterType<SMTPLocal>().As<ISMTP>();
            container.RegisterType<SMTP>().As<ISMTP>();
            container.RegisterType<Mailer>().As<IMailer>();
            container.RegisterType<Person>().As<IPerson>();
            

            return container.Build();
        }
    }
}

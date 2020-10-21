using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCreation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bubbelgum bubblegum = new Bubbelgum();
            bubblegum.flavour = "Jenka";

            Repository<Bubbelgum> bubbelRepo = new Repository<Bubbelgum>();

            bubbelRepo.SaveToRepo(bubblegum);
            Bubbelgum bubbelgum = bubbelRepo.GetItemFromDataBase(0);


            Bil bil = new Bil();
            bil.Model = "Seat";

            Repository<Bil> carRepo = new Repository<Bil>();

            carRepo.SaveToRepo(bil);
            Bil bil1 = carRepo.GetItemFromDataBase(0);

            Repository<Person> personRepo = new Repository<Person>();

            personRepo.SaveToRepo(new Person { Age = 43, Name = "Benny" });
            personRepo.SaveToRepo(new Person { Age = 99, Name = "Jenny" });

            Person person1 = personRepo.GetItemFromDataBase(0);
            Person person2 = personRepo.GetItemFromDataBase(1);

            //repository.RemoveItem(person);

            foreach(var item in personRepo)
            {
                Console.WriteLine($"{item.Name} och {item.Age}");
            }

            foreach (var item in carRepo)
            {
                Console.WriteLine($"{item.Model}");
            }

            foreach (var item in bubbelRepo)
            {
                Console.WriteLine($"Smaken på tuggumit är {item.flavour}");
            }

            //Console.WriteLine($"{person1.Name} och {person1.Age}");
            //Console.WriteLine($"{person2.Name} och {person2.Age}");

            Console.ReadLine();
        }
    }
}

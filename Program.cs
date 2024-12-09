namespace Persons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie Ihren Namen ein:");
            string userName = Console.ReadLine();

            Person person1 = new Person("Heinrich Keller", 30, "Softwareentwickler");
            Person person2 = new Person("Lina Reiner", 28, "Lehrerin");

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Wählen Sie eine Option:");
                Console.WriteLine("1. Person 1 begrüßen");
                Console.WriteLine("2. Person 2 begrüßen");
                Console.WriteLine("3. Infos zu Person 1 anzeigen");
                Console.WriteLine("4. Infos zu Person 2 anzeigen");
                Console.WriteLine("5. Beenden");
                Console.Write("Ihre Auswahl: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        person1.Begruessung(userName);
                        break;
                    case "2":
                        person2.Begruessung(userName);
                        break;
                    case "3":
                        person1.Infos();
                        break;
                    case "4":
                        person2.Infos();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte versuchen Sie es erneut.");
                        break;
                }

                if (choice != "5")
                {
                    Console.WriteLine("\nDrücken Sie eine beliebige Taste, um fortzufahren...");
                    Console.ReadKey();
                }
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Alter { get; set; }
        public string Beruf { get; set; }

        public Person(string name, int alter, string beruf)
        {
            Name = name;
            Alter = alter;
            Beruf = beruf;
        }
        public void Begruessung(string userName)
        {
            Console.WriteLine($"Hallo {userName}, mein Name ist {Name}. Ich bin {Alter} Jahre alt und arbeite als {Beruf}.");
        }

        public void Infos()
        {
            Console.WriteLine($"Name: {Name}, Alter: {Alter}, Beruf: {Beruf}");
        }
    }
}

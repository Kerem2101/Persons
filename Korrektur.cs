using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    internal class Korrektur
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo User! Bitte gib einen Namen ein.");
            string userName = Console.ReadLine();

            Person person1 = new Person("Maria", 31, "Metzgerin");
            Person person2 = new Person("Rainer", 40, "Programmierer");

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Wähle eine Person aus (1 - 2):\n\n1.{person1.Name}\n2.{person2.Name}");
                string input Console.ReadLine();

                if(input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Soll die person dich begrüßen, oder sollen die Information der Person ausgegeben werden? (1 - 2):\n1.Begrüßung\n2.Infos");
                    input = Console.ReadLine();

                    if(input == "1")
                    {
                        Console.Clear();
                        person1.Begruessung(userName);
                        Console.ReadKey();
                    }
                    else if(input == "2")
                    {
                        Console.Clear();
                        person1.Infos(userName);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Deine Eingabe ist fehlerhaft!");
                        Console.ReadKey();
                    }
                }
                else if(input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Soll die person dich begrüßen, oder sollen die Information der Person ausgegeben werden? (1 - 2):\n1.Begrüßung\n2.Infos");
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.Clear();
                        person2.Begruessung(userName);
                        Console.ReadKey();
                    }
                    else if (input == "2")
                    {
                        Console.Clear();
                        person2.Infos(userName);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Deine Eingabe ist fehlerhaft!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Deine Eingabe war nicht korrekt!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
// In C# (und auch anderen Sprachen) kann statt mit Get- und Set- Methoden auch mit Eigenschaften gearbeitet werden.
// Dies erleichtert Verwendung und Zugriff.
// Um die Eigenschaften zu erstellen, makiert man alle Felder, führt einen Rechtsklick aus
// und wählt dann "Schnellaktionen und Refractorings" aus
// Dann "Konstruktor" und dann das gleiche nochmal und "Felder Kapseln (jedoch weiterhin verwenden)"
//Um die Eigenschaften zu erstellen , makiert man alle Felder, führt einen Rechtsklick aus
//und wählt dann "Schnellaktionen und Refactorings" aus.
//Dann "Konstruktor" und dann das gleiche nochmal und "Felder Kapseln (jedoch weiterhin verwenden)"
//Im Grunde ersetzten die Eigenschaften einfach die Methoden mit Get und Set und das in einer deutlich kürzeren Schreibweise


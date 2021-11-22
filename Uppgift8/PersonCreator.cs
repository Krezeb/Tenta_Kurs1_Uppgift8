using System;
using System.Collections.Generic;

namespace Uppgift8
{
    abstract class PersonCreator
    {
        protected List<Person> _people;

        public PersonCreator()
        {
            _people = new List<Person>();
        }

        public void CreatePeople()
        {
            int age = 0;
            double height = 0.0;
            while (true)
            {
                Console.WriteLine("Enter a name");
                string name = Console.ReadLine();
                while (true) // Hade några minuter över. Införde Try/Catch
                {
                    try
                    {
                        Console.WriteLine("Enter an age");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Ogiltig inmating. Försök igen...");
                        continue;
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter a height");
                        height = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Ogiltig inmating. Försök igen...");
                        continue;
                    }
                }

                Person person = new Person()
                {
                    Name = name,
                    Age = age,
                    Height = height
                };
                _people.Add(person);

                Console.WriteLine("Press Esc to stop creating persons. Press any other key to create another person.");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

            StorePeople(_people);
        }
        protected abstract void StorePeople(List<Person> _people);
    }
}

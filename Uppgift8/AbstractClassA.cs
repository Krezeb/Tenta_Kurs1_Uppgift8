using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift8
{
    class AbstractClassA : PersonCreator
    {
        protected override void StorePeople(List <Person>_people)
        {
            string format = "{0,-20} {1,5} {2,7}";
            Console.WriteLine(format, "Namn", "Ålder", "Längd");
            foreach (var item in _people)
            {
                string height = item.Height.ToString("n2");
                Console.WriteLine(format, item.Name, item.Age, height);
            }
        }
    }
}

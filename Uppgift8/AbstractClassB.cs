using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift8
{
    class AbstractClassB : PersonCreator
    {
        protected override void StorePeople(List<Person> _people)
        {
            using (FileStream fs = File.OpenWrite("person.txt")) // Nu gick det att använda 2st using
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var item in _people)
                    {
                        string tempLine = item.Name + "§" + item.Age + "§" + item.Height;
                        sw.WriteLine(tempLine); // Jag skriver ut det mesta för att hålla det tydlig för mig själv.
                                                // Jag vet att det går att skriva kortare syntax
                                                // t.ex sw.WriteLine(item.Name + "§" + item.Age + "§" + item.Height);
                    }
                }
            }
        }

    }
}

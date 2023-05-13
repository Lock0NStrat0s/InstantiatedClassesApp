using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI;

public static class ProcessPerson
{
    public static void GreetPerson(PersonModel person)
    {
        Console.WriteLine($"Hello {person.LastName}");
        person.HasBeenGreeted = true;
    }
}

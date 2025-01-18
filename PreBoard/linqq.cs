using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

        var filteredNames = from name in names
                            where name.StartsWith("C")
                            select name;

        Console.WriteLine("Filtered Names (where):");
        foreach (var name in filteredNames)
        {
            Console.WriteLine(name);
        }

        bool containsAlice = names.Contains("Alice");
        Console.WriteLine($"\nList contains 'Alice': {containsAlice}");

        var sortedNames = from name in names
                          orderby name
                          select name;

        Console.WriteLine("\nSorted Names (orderBy):");
        foreach (var name in sortedNames)
        {
            Console.WriteLine(name);
        }

        var upperCaseNames = from name in names
                             select name.ToUpper();

        Console.WriteLine("\nNames in Uppercase (select):");
        foreach (var name in upperCaseNames)
        {
            Console.WriteLine(name);
        }
    }
}

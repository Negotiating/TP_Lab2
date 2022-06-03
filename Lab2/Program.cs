using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Library> libraries = new List<Library>()
            {
                new Book(new Author("Леру","Гастон"), "Призрак оперы", 120, "ИЗДАТЕЛЬСТВО","Роман"),
                new Book(new Author("Остин","Джейн"), "Гордость и предубеждение", 210, "ИЗДАТЕЛЬСТВО","Тоже роман"),
                new Magazine(new Author("Пелс", "Джессика"), "Cosmopolitan", 23, "Cosmopolitan", "журналы для женщин")
            };
            foreach (Library library in libraries)
            {
                Console.WriteLine(library.GetInfo());
            }
            Console.ReadLine();
        }
    }
}

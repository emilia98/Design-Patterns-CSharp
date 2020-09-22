using DocumentsCreator.ConcreteCreator;
using DocumentsCreator.Creator;
using System;

namespace DocumentsCreator
{
    public class StartUp
    {
        static void Main()
        {
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine($"{document.GetType().Name} --");

                foreach (var page in document.Pages)
                {
                    Console.WriteLine($" {page.GetType().Name}");
                }

                Console.WriteLine();
            }
        }
    }
}

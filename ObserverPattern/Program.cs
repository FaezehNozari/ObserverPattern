using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Reader reader = new Reader("Faezeh");
            publisher.Activation(reader);
            Library library = new Library("library tesla");
            publisher.Activation(library);

            publisher.UploadArticle(" Hi ,My new article has been uploaded");

            Console.ReadKey();

        }
    }
}

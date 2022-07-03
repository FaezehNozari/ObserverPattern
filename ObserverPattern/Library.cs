using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Library:IReader
    {
        private readonly string _libraryName;
        public Library(string libraryName)
        {
            _libraryName = libraryName;
        }
        public void Update(IPublisher publisher)
        {
            Console.WriteLine($"{_libraryName}: Received the article (: ");
        }
    }
}

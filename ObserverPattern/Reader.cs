using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Reader : IReader
    {

        private readonly string _readerName;
        public Reader(string readerName)
        {
            _readerName = readerName;
        }
        public void Update(IPublisher publisher)
        {
            Console.WriteLine($"{_readerName}: Received the article (: ");
        }
    }
}

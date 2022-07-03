using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Publisher : IPublisher
    {
        private List<IReader> _reder = new List<IReader>();
        public void Activation(IReader reader)
        {
            this._reder.Add(reader);
        }

        public void Deactivation(IReader reader)
        {
            this._reder.Remove(reader);
        }

        public void Notify()
        {
            foreach (var reader in _reder)
            {
                reader.Update(this);
            }
        }
        public void UploadArticle(string article)
        {
            Console.WriteLine($" \n{article} ");

            Notify();
        }
    }
}

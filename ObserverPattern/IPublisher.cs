using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IPublisher
    {
        void Activation(IReader reader);
        void Deactivation(IReader reader);
        void Notify();
    }
}

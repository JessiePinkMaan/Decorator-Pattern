using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public abstract class Notdecor : INotifier
    {
        protected INotifier n1;

        public Notdecor(INotifier notifier)
        {
            n1 = notifier;
        }

        public virtual void Send(string message)
        {
            n1.Send(message);
        }
    }

}

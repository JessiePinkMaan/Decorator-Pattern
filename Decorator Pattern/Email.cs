using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Email : INotifier
    {
        //масив с почтамии а
        private string[] _arremail;

        public Email(string[] e)
        {
            _arremail = e;
        }

        public void Send(string message)
        {
            //проходимся по каждой почте через цикл и выводим в консоль сообщение 
            foreach (var em in _arremail)
            {
                Console.WriteLine($"отправиленно на почту : {em}: {message}");
            }
        }
    }
}


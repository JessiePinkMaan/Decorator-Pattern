using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Sms : Notdecor
    {
        private string[] telephonNumber;
        public Sms(INotifier notifier , string[] tn) : base(notifier) // принимаем INotifier и передает его в базовый класс\\
        {
            telephonNumber = tn;
        } 

        public override void Send(string message)
        {
            base.Send(message);     //вызываем send у базового класса Notdecor который вызывает метод send у Email
            foreach (var nom in telephonNumber)
            {
                Console.WriteLine($"отправка смски на номер :{nom} {message}");
            }
        }
    }


}

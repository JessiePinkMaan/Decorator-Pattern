using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class TelegramNot : Notdecor
    {
        private string[] telegramUsName;
        public TelegramNot(INotifier notifier, string[] tg) : base(notifier) {

            telegramUsName = tg;
        }

        public override void Send(string message)
        {
            base.Send(message);
            foreach (var username in telegramUsName)
            {
                Console.WriteLine($"Телеграмм уведомление для @{username}: {message}");
            }
        }
    }

}

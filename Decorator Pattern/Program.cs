namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] adminEmails = { "sobaka@gmail.com", "gruz200_pozitiv_smail@gmail.com" };

            string[] TelephonBaza = { "79994634084", "866683424232" };

            string[] telegramUsernames = { "AlekseyBalabashka", "melchakovDOGlover", "Bevebake" };

            //создаем уведомитель для емаил
            INotifier notifier = new Email(adminEmails);

          //оборачиваем его в смс уведомитель 
            notifier = new Sms(notifier , TelephonBaza);

            //оборачиваем его в тг уведомитель 
            notifier = new TelegramNot(notifier , telegramUsernames);

            //выводим сообщение через все используемые уведомители 
            notifier.Send("успех!!!!");
        }
    }

}
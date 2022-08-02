using System;

namespace CarChainOfResponsibility
{
    class Reseption : Participant
    {
        readonly LevelsOfResponsibility priority;
        public Reseption(LevelsOfResponsibility priority)
        {
            this.priority = priority;
        }
        public Participant Next { get; set; }

        public override void Conversation(string message, LevelsOfResponsibility level)
        {
            Console.WriteLine("Здравсти!\n" +
                       "Меня звовут Вальдемар\n" +
                       "Спасибо, за звонок!"
                       );

            if (level <= priority) 
            {
                
                if (message.IndexOf("телефон") != -1) Console.WriteLine("Номер телефона 8-123-456-78-90");
                if (message.IndexOf("работ") != -1) Console.WriteLine("Часы работы диллерского центра с 8:00 до 21:00");
            }
            else if (Next != null)
            {
                Next.Conversation(message, level);
            }
        }
    }
}

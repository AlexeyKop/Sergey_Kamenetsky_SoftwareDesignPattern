using System;

namespace CarChainOfResponsibility
{
    class Manager : Participant
    {
        readonly LevelsOfResponsibility priority;
        public Manager(LevelsOfResponsibility priority)
        {
            this.priority = priority;
        }
        public Participant Next { get; set; }

        public override void Conversation(string message, LevelsOfResponsibility level)
        {
            Console.WriteLine("Здрасти, это Джерри. Слушаю вас");
            if (level <= priority) 
            { 
                Console.WriteLine(message);
            }
            else if (Next != null)
            {
                Next.Conversation(message, level);
            }
        }
    }
}

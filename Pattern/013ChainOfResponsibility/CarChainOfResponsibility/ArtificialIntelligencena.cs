using System;

namespace CarChainOfResponsibility
{
    class ArtificialIntelligencena : Participant
    {
        readonly LevelsOfResponsibility priority;
        public ArtificialIntelligencena(LevelsOfResponsibility priority)
        {
            this.priority = priority;
        }
        public Participant Next { get; set; }

        public override void Conversation(string message, LevelsOfResponsibility level)
        {
            #region _

            //int a;
            //do
            //{
            //    Console.Write(
            //        "для связи с диллерским центром Kia - нажмите 1\n" +
            //        "для связи с диллерским центром Lexus - нажмите 2\n" +
            //        "для связи с диллерским центром Porsche - нажмите 3\n" +
            //        "Если вам нужена помощь в выборе - нажмите 4\n" +
            //        "Время ожидания может составить 100500 минут, \nесли хотите заказать обратный звонок - нажмите 6\n" +
            //        "\n" +
            //        "Ваш ответ:"
            //        );

            //    var f = int.TryParse(Console.ReadLine(), out a);
            //} while (Array.IndexOf(new[] { 4, 1, 2, 3, 6 }, a) != -1);



            #endregion
            Console.WriteLine("Здравствуйте, уважаемый клиент!\n" +
                "Спасибо, что обратились в наш диллерский центр Ololo!\n" +
                "Мы всегда рады когда нам звонят!\n" +
                "Ваш звонок очень важен для нас\n" +
                "блаблабла\n" +
                "Пожалуйста, дождитесь ответа оператора"
                );
            if (level <= priority) 
            { 
                //Console.WriteLine(message);
            }
            else if (Next != null)
            {
                Next.Conversation(message.ToLower(), level);
            }
        }
    }
}

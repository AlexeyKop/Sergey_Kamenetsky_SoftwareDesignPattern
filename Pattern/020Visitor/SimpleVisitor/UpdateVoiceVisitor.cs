using static System.Console;
namespace SimpleVisitor
{
    class UpdateVoiceVisitor : VoiceVisitor
    {
        public override void Make(Bird bird)
        {
            if (bird is Kiwi) WriteLine("Киви что-то там, но что неизвестно...");
            else base.Make(bird);
        }
    }
}

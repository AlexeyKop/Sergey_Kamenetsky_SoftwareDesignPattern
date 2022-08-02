namespace CarChainOfResponsibility
{
    abstract class Participant
    {
        public abstract void Conversation(string message, LevelsOfResponsibility level);
    }
}

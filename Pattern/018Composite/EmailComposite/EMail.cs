using static System.Console;

namespace EmailComposite
{
    class EMail : IEMail
    {
        public string Name { get; set; }
        public void Send() => WriteLine($"Отправлено \"{Name}\"");
    }
}

namespace EmailComposite
{
    interface IEMail {
        string Name { get; set; }
        void Send();
    }
}

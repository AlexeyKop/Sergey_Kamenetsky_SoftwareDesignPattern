namespace Ex23_OpenClosedPrinciple
{
    public class EmailService
    {
        private string email;
        private string text;
        private string subject;
        private Attach[] attach;
        public EmailService(string email, 
                            string text = "",
                            string subject= "",
                            params Attach[] args
                            )
        {
            this.email = email;
            this.text = text;
            this.subject = subject;
            this.attach = args;
        }
        public void SendTo(string email, string text, string subject)
        {
            return;
        }
    }
}

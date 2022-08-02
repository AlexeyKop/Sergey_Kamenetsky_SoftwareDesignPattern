namespace VirtualProxy
{
    class Client
    {
        private string id;
        public string Id { get => this.id; }

        public Client(string id = "#2021")
        {
            this.id = id;
        }
    }
}

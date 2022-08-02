using System;

namespace Ex23_OpenClosedPrinciple
{
    public class SftpService
    {
        private readonly string ftp;
        private readonly int port;
        private readonly User user;
        private readonly Attach[] attach;
        private readonly Guid key;


        public SftpService(string ftp, 
                          int port,
                          User user, 
                          Guid token,
                          params Attach[] args)
        {
            this.ftp = ftp;
            this.port = port;
            this.user = user;
            this.attach = args;
            this.key = token;

        }

        public void Upload()
        {
            return;
        }
    }
}

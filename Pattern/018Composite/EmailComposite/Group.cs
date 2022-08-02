using System.Collections.Generic;

namespace EmailComposite
{
    class Group : IEMail
    {
        public string Name { get; set; }
        private List<IEMail> eMails = new List<IEMail>();
        public Group(params IEMail[] es) => Append(es);
        public void Append(params IEMail[] es)
        {
            foreach (var item in es) eMails.Add(item);
        }
        public void Send()
        {
            foreach (var item in eMails) item.Send();
        }
    }
}

using System;
namespace MongoDB.Domain
{
    public class Quote
        : IQuote
    {
        public Quote()
        {
        }

        public string Id { get; set; }
        public string Number { get; set; }
        public int Version { get; set; }
        public string Description { get; set; }
    }
}

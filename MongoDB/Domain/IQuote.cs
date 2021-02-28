using System;
namespace MongoDB.Domain
{
    public interface IQuote
    {
        public string Id { get; set; }
        public string Number { get; set; }
        public int Version { get; set; }
    }
}

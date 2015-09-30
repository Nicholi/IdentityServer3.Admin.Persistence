using System;

namespace IdentityServer3.Admin.Persistence.Models.Storage
{
    public class ClientSecret
    {
        public virtual int Id { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? Expiration { get; set; }
        public virtual Client Client { get; set; }
    }
}
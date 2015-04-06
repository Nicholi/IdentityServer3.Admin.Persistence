using System;

namespace IdentityServer3.Admin.Persistence.Models.Storage
{
    public class ClientSecret
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public DateTimeOffset? Expiration { get; set; } 
    }
}
namespace IdentityServer3.Admin.Persistence.Models.Storage
{
    public class ClientPostLogoutRedirectUri
    {
        public virtual int Id { get; set; }
        public virtual string Uri { get; set; }
        public virtual Client Client { get; set; }
    }
}
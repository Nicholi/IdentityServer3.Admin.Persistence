namespace Thinktecture.IdentityServer3.Admin.Persistence.Models.Storage
{
    public class ClientIdPRestriction
    {
        public virtual int Id { get; set; }
        public virtual string Provider { get; set; }
        public virtual Client Client { get; set; }
    }
}
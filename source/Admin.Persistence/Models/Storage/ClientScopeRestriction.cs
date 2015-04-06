namespace IdentityServer3.Admin.Persistence.Models.Storage
{
    public class ClientScopeRestriction
    {
        public virtual int Id { get; set; }
        public virtual string Scope { get; set; }
        public virtual Client Client { get; set; }
    }
}
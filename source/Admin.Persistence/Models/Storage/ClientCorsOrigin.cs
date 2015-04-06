namespace IdentityServer3.Admin.Persistence.Models.Storage
{
    public class ClientCorsOrigin
    {
        public virtual int Id { get; set; }
        public virtual string Origin { get; set; }
        public virtual Client Client { get; set; }
    }
}
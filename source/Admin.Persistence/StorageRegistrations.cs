using IdentityServer3.Admin.Persistence.Models.Storage;
using Thinktecture.IdentityServer.Core.Configuration;

namespace IdentityServer3.Admin.Persistence
{
    public abstract class StorageRegistrations
    {
        public abstract Registration<IPersistence<Scope>> ScopePersistence { get; }
        public abstract Registration<IPersistence<Client>> ClientPersistence { get; }
    }
}
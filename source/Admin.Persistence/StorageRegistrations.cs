using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer3.Admin.Persistence.Models.Storage;

namespace Thinktecture.IdentityServer3.Admin.Persistence
{
    public abstract class StorageRegistrations
    {
        public abstract Registration<IPersistence<Scope>> ScopePersistence { get; }
        public abstract Registration<IPersistence<Client>> ClientPersistence { get; }
    }
}
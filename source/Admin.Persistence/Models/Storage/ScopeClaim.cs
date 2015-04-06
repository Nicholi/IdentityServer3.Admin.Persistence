﻿namespace IdentityServer3.Admin.Persistence.Models.Storage
{
    public class ScopeClaim
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual bool AlwaysIncludeInIdToken { get; set; }
        public virtual Scope Scope { get; set; }
    }
}
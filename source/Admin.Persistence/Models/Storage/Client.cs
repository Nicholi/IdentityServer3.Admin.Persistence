﻿using System.Collections.Generic;
using Thinktecture.IdentityServer.Core.Models;

namespace Thinktecture.IdentityServer3.Admin.Persistence.Models.Storage
{
    public class Client
    {
        public virtual int Id { get; set; }
        public virtual bool Enabled { get; set; }
        public virtual string ClientId { get; set; }
        public virtual ICollection<ClientSecret> ClientSecrets { get; set; }
        public virtual string ClientName { get; set; }
        public virtual string ClientUri { get; set; }
        public virtual string LogoUri { get; set; }
        public virtual bool RequireConsent { get; set; }
        public virtual bool AllowRememberConsent { get; set; }
        public virtual Flows Flow { get; set; }
        public virtual ICollection<ClientRedirectUri> RedirectUris { get; set; }
        public virtual ICollection<ClientPostLogoutRedirectUri> PostLogoutRedirectUris { get; set; }
        public virtual ICollection<ClientScopeRestriction> ScopeRestrictions { get; set; }
        public virtual int IdentityTokenLifetime { get; set; }
        public virtual int AccessTokenLifetime { get; set; }
        public virtual int AuthorizationCodeLifetime { get; set; }
        public virtual int AbsoluteRefreshTokenLifetime { get; set; }
        public virtual int SlidingRefreshTokenLifetime { get; set; }
        public virtual TokenUsage RefreshTokenUsage { get; set; }
        public virtual TokenExpiration RefreshTokenExpiration { get; set; }
        public virtual AccessTokenType AccessTokenType { get; set; }
        public virtual bool EnableLocalLogin { get; set; }
        public virtual ICollection<ClientIdPRestriction> IdentityProviderRestrictions { get; set; }
        public virtual bool IncludeJwtId { get; set; }
        public virtual ICollection<ClientClaim> Claims { get; set; }
        public virtual bool AlwaysSendClientClaims { get; set; }
        public virtual bool PrefixClientClaims { get; set; }
        public virtual ICollection<ClientGrantTypeRestriction> CustomGrantTypeRestrictions { get; set; }

        public Client()
        {
            // Copied from original Client model
            Enabled = true;
            EnableLocalLogin = true;

            // client claims settings
            AlwaysSendClientClaims = false;
            PrefixClientClaims = true;

            // 5 minutes
            AuthorizationCodeLifetime = 300;
            IdentityTokenLifetime = 300;

            // one hour
            AccessTokenLifetime = 3600;

            // 30 days
            AbsoluteRefreshTokenLifetime = 2592000;

            // 15 days
            SlidingRefreshTokenLifetime = 1296000;

            RefreshTokenUsage = TokenUsage.OneTimeOnly;
            RefreshTokenExpiration = TokenExpiration.Absolute;

            AccessTokenType = AccessTokenType.Jwt;

            RequireConsent = true;
            AllowRememberConsent = true;
        }
    }
}
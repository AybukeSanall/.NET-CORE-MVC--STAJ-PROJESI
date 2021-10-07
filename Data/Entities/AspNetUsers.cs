using System;
using System.Collections.Generic;

namespace StajProjesiIdentity.Data.Entities
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            #region Generated Constructor
            UserAspNetUserClaims = new HashSet<AspNetUserClaims>();
            UserAspNetUserLogins = new HashSet<AspNetUserLogins>();
            UserAspNetUserRoles = new HashSet<AspNetUserRoles>();
            UserAspNetUserTokens = new HashSet<AspNetUserTokens>();
            #endregion
        }

        #region Generated Properties
        public string Id { get; set; }

        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string ConcurrencyStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<AspNetUserClaims> UserAspNetUserClaims { get; set; }

        public virtual ICollection<AspNetUserLogins> UserAspNetUserLogins { get; set; }

        public virtual ICollection<AspNetUserRoles> UserAspNetUserRoles { get; set; }

        public virtual ICollection<AspNetUserTokens> UserAspNetUserTokens { get; set; }

        #endregion

    }
}

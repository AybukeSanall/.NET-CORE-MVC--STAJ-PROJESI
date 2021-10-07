using System;
using System.Collections.Generic;

namespace StajProjesiIdentity.Data.Entities
{
    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            #region Generated Constructor
            RoleAspNetRoleClaims = new HashSet<AspNetRoleClaims>();
            RoleAspNetUserRoles = new HashSet<AspNetUserRoles>();
            #endregion
        }

        #region Generated Properties
        public string Id { get; set; }

        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public string ConcurrencyStamp { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<AspNetRoleClaims> RoleAspNetRoleClaims { get; set; }

        public virtual ICollection<AspNetUserRoles> RoleAspNetUserRoles { get; set; }

        #endregion

    }
}

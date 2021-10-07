using System;
using System.Collections.Generic;

namespace StajProjesiIdentity.Data.Entities
{
    public partial class AspNetUserRoles
    {
        public AspNetUserRoles()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public string UserId { get; set; }

        public string RoleId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual AspNetRoles RoleAspNetRoles { get; set; }

        public virtual AspNetUsers UserAspNetUsers { get; set; }

        #endregion

    }
}

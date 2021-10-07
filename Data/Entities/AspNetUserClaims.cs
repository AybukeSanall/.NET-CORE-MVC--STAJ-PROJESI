using System;
using System.Collections.Generic;

namespace StajProjesiIdentity.Data.Entities
{
    public partial class AspNetUserClaims
    {
        public AspNetUserClaims()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string UserId { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        #endregion

        #region Generated Relationships
        public virtual AspNetUsers UserAspNetUsers { get; set; }

        #endregion

    }
}

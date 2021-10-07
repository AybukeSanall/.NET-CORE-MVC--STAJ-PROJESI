using System;
using System.Collections.Generic;

namespace StajProjesiIdentity.Data.Entities
{
    public partial class AspNetUserLogins
    {
        public AspNetUserLogins()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        public string ProviderDisplayName { get; set; }

        public string UserId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual AspNetUsers UserAspNetUsers { get; set; }

        #endregion

    }
}

using System;
using System.Collections.Generic;

namespace StajProjesi.Data.Entities
{
    public partial class Ilceler
    {
        public Ilceler()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int İd { get; set; }

        public string İlceadi { get; set; }

        public int Sehirid { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Iller SehiridIller { get; set; }

        #endregion

    }
}

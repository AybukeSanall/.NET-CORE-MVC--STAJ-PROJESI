using System;
using System.Collections.Generic;

namespace StajProjesi.Data.Entities
{
    public partial class Iller
    {
        public Iller()
        {
            #region Generated Constructor
            SehiridIlcelers = new HashSet<Ilceler>();
            #endregion
        }

        #region Generated Properties
        public int İd { get; set; }

        public string Sehiradi { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Ilceler> SehiridIlcelers { get; set; }

        #endregion

    }
}

using StajProjesi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajProjesi.Models
{
    public class SehirGosterViewModel
    {
        public SehirGosterViewModel()
        {

        }

        public List<Iller> Sehirler { get; internal set; }

        public List<Ilceler> Ilceler { get; internal set; }

    }
}

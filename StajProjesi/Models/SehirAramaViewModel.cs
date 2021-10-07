using StajProjesi.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace StajProjesi.Models
{
    public class SehirAramaViewModel
    {
        public SehirAramaViewModel()
        {

        }

        public List<Iller> Sehirler { get; internal set; }

        public List<Ilceler> Ilceler { get; internal set; }


    }
}         
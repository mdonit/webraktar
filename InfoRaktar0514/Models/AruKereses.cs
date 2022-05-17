using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoRaktar0514.Models
{
    public class AruKereses
    {
        public string MegnevezesKeres { get; set; }
        public string BeszallitoKeres { get; set; }
        public List<Aru> AruLista { get; set; }
        public SelectList BeszallitoLista { get; set; }
    }
}

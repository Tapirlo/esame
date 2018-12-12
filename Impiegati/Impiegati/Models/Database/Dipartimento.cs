using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Impiegati.Models.Database
{
    public class Dipartimento
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Area { get; set; }
        public int? Manager { get; set; }

        public Impiegato ImpiegatoNavigation { get; set; }

        public ICollection<Impiegato> Impiegati { get; set; }
    }
}

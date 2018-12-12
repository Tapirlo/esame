using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Impiegati.Models.Database
{
    public class Impiegato
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime Datanascita { get; set; }
        public DateTime Dataassunzione { get; set; }
        public int? Dipartimento { get; set; }

        public Dipartimento DipartimentoNavigation { get; set; }

        public ICollection<Dipartimento> Dipartimenti { get; set; }


    }
}

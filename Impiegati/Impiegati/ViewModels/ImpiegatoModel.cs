using Impiegati.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Impiegati.ViewModels
{
    public class ImpiegatoModel
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime Datanascita { get; set; }
        public DateTime Dataassunzione { get; set; }
        public String Dipartimento { get; set; }

        public ImpiegatoModel()
        {

        }

        public ImpiegatoModel(Impiegato impiegato)
        {
            Id = impiegato.Id;
            Nome = impiegato.Nome;
            Datanascita = impiegato.Datanascita;
            Dataassunzione = impiegato.Dataassunzione;
            Dipartimento = impiegato.DipartimentoNavigation.Nome;
        }
    }
}

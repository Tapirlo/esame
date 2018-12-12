using Impiegati.Models.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Impiegati.Models
{
    public class Repository : IDisposable
    {
        private Contesto contesto;
        public void Dispose()
        {
            contesto.Dispose();
        }

        public Repository(Contesto c)
        {
            contesto = c;
        }

        public List<Impiegato> GetImpiegati()
        {
            return contesto.Impiegati.Include(x=>x.DipartimentoNavigation).ToList();
        }

        public List<Impiegato> ImpiegatiPiuAnziani(int n,int dipartimento)
        {
            return contesto.Impiegati.Where(x => x.Dipartimento == dipartimento).OrderByDescending(x => x.Dataassunzione).Take(n).Include(x=>x.DipartimentoNavigation).ToList();
        }

        internal List<Dipartimento> GetDipartimenti()
        {
            return contesto.Dipartimenti.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impiegati.Models;
using Impiegati.Models.Database;
using Microsoft.AspNetCore.Mvc;

namespace Impiegati.Controllers
{
    [Route("api/dipartimenti")]
    public class DipartimentiController : Controller
    {
        private Repository repository;

        public DipartimentiController(Repository r)
        {
            repository = r;
        }
       

        public List<Dipartimento> GetDipartimenti()
        {
            return repository.GetDipartimenti();
        }
    }
}
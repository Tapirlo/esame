using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impiegati.Models;
using Impiegati.Models.Database;
using Impiegati.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Impiegati.Controllers
{
    [Route("api/impiegati")]
    public class ImpiegatiController : Controller
    {
        private Repository repository;
        public ImpiegatiController(Repository r)
        {
            repository = r;
        }
        public List<ImpiegatoModel> GetImpiegati([FromQuery] int numero,[FromQuery] int dipartimento)
        {
            if(numero==0)
            {
                return repository.GetImpiegati().Select(x => new ImpiegatoModel(x)).ToList();

            }

            else
{
                return repository.ImpiegatiPiuAnziani(numero, dipartimento).Select(x => new ImpiegatoModel(x)).ToList();

            }
        }

    }
}
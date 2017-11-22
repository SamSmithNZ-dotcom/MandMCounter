using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MandMCounter.Core;

namespace MandMCounter.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Units")]
    public class UnitsController : Controller
    {
        [HttpGet("GetUnitsForVolume")]
        public List<string> GetUnitsForVolume()
        {
            Units unit = new Units();
            return unit.GetUnitsForVolume();
        }

        [HttpGet("GetUnitsForContainer")]
        public List<string> GetUnitsForContainer()
        {
            Units unit = new Units();
            return unit.GetUnitsForContainer();
        }

    }
}
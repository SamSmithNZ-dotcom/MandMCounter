using MandMCounter.Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MandMCounter.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Units")]
    public class UnitsController : Controller
    {
        [HttpGet("GetUnitsForVolume")]
        public List<string> GetUnitsForVolume()
        {
            return Units.GetUnitsForVolume();
        }

        [HttpGet("GetUnitsForContainer")]
        public List<string> GetUnitsForContainer()
        {
            return Units.GetUnitsForContainer();
        }

    }
}
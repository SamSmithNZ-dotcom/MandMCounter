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
    [Route("api/MandMCounter")]
    public class MandMCounterController : Controller
    {
        public float GetData()
        {
            Calculator calc = new Calculator();
            return calc.CountMandMs("quart", 3);
        }
    }
}
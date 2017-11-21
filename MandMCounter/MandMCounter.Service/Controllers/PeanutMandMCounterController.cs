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
    [Route("api/PeanutMandMCounter")]
    public class PeanutMandMCounterController : Controller
    {
        [HttpGet("GetDataForUnit")]
        public float GetDataForUnit(string unit, float quantity)
        {
            Calculator calc = new Calculator();
            return calc.CountPeanutMandMs(unit, quantity);
        }

        [HttpGet("GetDataForRectangle")]
        public float GetDataForRectangle(string unit, float height, float width, float length)
        {
            Calculator calc = new Calculator();
            return calc.CountPeanutMandMs(unit, height, width, length);
        }

        [HttpGet("GetDataForCylinder")]
        public float GetDataForCylinder(string unit, float height, float radius)
        {
            Calculator calc = new Calculator();
            return calc.CountPeanutMandMs(unit, height, radius);
        }
    }
}
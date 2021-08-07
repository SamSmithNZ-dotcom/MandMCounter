using MandMCounter.Core;
using Microsoft.AspNetCore.Mvc;

namespace MandMCounter.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/PeanutMandMCounter")]
    public class PeanutMandMCounterController : Controller
    {
        [HttpGet("GetDataForUnit")]
        public float GetDataForUnit(string unit, float quantity)
        {
            return Calculator.CountPeanutMandMs(unit, quantity);
        }

        [HttpGet("GetDataForRectangle")]
        public float GetDataForRectangle(string unit, float height, float width, float length)
        {
            return Calculator.CountPeanutMandMs(unit, height, width, length);
        }

        [HttpGet("GetDataForCylinder")]
        public float GetDataForCylinder(string unit, float height, float radius)
        {
            return Calculator.CountPeanutMandMs(unit, height, radius);
        }
    }
}
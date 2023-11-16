using MandMCounter.Core;
using Microsoft.AspNetCore.Mvc;

namespace MandMCounter.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/SkittleCounter")]
    public class SkittleCounterController : Controller
    {
        [HttpGet("GetDataForUnit")]
        public float GetDataForUnit(string unit, float quantity)
        {
            return Calculator.CountSkittles(unit, quantity);
        }

        [HttpGet("GetDataForRectangle")]
        public float GetDataForRectangle(string unit, float height, float width, float length)
        {
            return Calculator.CountSkittles(unit, height, width, length);
        }

        [HttpGet("GetDataForCylinder")]
        public float GetDataForCylinder(string unit, float height, float radius)
        {
            return Calculator.CountSkittles(unit, height, radius);
        }
    }
}
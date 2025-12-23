using MandMCounter.Core;
using Microsoft.AspNetCore.Mvc;

namespace MandMCounter.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/JellyBeanCounter")]
    public class JellyBeanCounterController : Controller
    {
        [HttpGet("GetDataForUnit")]
        public float GetDataForUnit(string unit, float quantity)
        {
            return Calculator.CountJellyBeans(unit, quantity);
        }

        [HttpGet("GetDataForRectangle")]
        public float GetDataForRectangle(string unit, float height, float width, float length)
        {
            return Calculator.CountJellyBeans(unit, height, width, length);
        }

        [HttpGet("GetDataForCylinder")]
        public float GetDataForCylinder(string unit, float height, float radius)
        {
            return Calculator.CountJellyBeans(unit, height, radius);
        }
    }
}

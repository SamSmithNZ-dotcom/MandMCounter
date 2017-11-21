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
        /// <summary>
        /// To count the number of M&Ms in a container based on unit volume (Quart/Gallon/Liter, etc)
        /// </summary>
        /// <param name="unit">String Quart/Gallon/Liter</param>
        /// <param name="quanity">Any float number</param>
        /// <returns>M&M count, as an unrounded float</returns>
        [HttpGet("{unit, quanity}")]
        public float GetDataForVolume(string unit, float quantity)
        {
            Calculator calc = new Calculator();
            return calc.CountMandMs(unit, quantity);
        }

        /// <summary>
        /// To count the number of M&Ms in a container based on rectangular container
        /// </summary>
        /// <param name="unit">Inch/ CM</param>
        /// <param name="height">the height of the rectangle</param>
        /// <param name="width">the width of the rectangle</param>
        /// <param name="length">the length of the rectangle</param>
        /// <returns>M&M count, as an unrounded float</returns>
        [HttpGet("{unit:string, height:float, width:float, length:float}")]
        public float GetDataForRectangle(string unit, float height, float width, float length)
        {
            Calculator calc = new Calculator();
            return calc.CountMandMs(unit, height, width, length);
        }

        /// <summary>
        /// To count the number of M&Ms in a container based on rectangular container
        /// </summary>
        /// <param name="unit">Inch/ CM</param>
        /// <param name="height">the height of the cylinder</param>
        /// <param name="radius">the radius of the container (half of the diameter)</param>
        /// <returns>M&M count, as an unrounded float</returns>
        [HttpGet("{unit:string, height:float, radius:float}")]
        public float GetDataForCylinder(string unit, float height, float radius)
        {
            Calculator calc = new Calculator();
            return calc.CountMandMs(unit, height, radius);
        }
    }
}
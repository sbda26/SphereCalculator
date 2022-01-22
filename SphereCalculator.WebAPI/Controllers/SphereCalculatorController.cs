using Microsoft.AspNetCore.Mvc;
using SphereCalculator.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SphereCalculator.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SphereCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public ActionResult<CalculatorOutput> Post([FromBody] SphereCalculator data)
        {
            try
            {
                var valueType = Enum.Parse<CalculatorEnum>(data.ValueType, true);
                var calc = new Calculator();

                calc.Calculate(data.Value, valueType);
                return calc.Output;
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

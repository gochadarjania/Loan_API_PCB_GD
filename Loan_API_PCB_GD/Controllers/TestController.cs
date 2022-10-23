using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loan_API_PCB_GD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //private readonly ILogger _logger;

        //public TestController(ILogger<TestController> logger)
        //{
        //    _logger = logger;
        //}
        //// GET api/values
        //[HttpGet("{id}")]
        //public ActionResult<IEnumerable<string>> Get(int id)
        //{
        //    _logger.LogInformation("Start : Getting item details for {ID}", id);

        //    List<string> list = new List<string>();
        //    list.Add("A");
        //    list.Add("B");

        //    _logger.LogInformation("Completed : Item details for {ID}", list);
        //    return list;
        //}
    }
}

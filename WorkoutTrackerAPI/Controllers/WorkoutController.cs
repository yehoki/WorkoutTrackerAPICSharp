using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkoutTrackerAPI.Controllers
{
    public class WorkoutController : ControllerBase
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}


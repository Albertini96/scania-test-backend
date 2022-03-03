using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using backend._Models;
namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarrosController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                db _db = new db();
                var ret = _db.getCarros();
                return Ok(ret);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using backend.Data;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaminhoesController : ControllerBase
    {
     
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                db _db = new db();
                return Ok(_db.getCaminhoes());
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}

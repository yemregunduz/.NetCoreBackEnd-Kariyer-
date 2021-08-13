using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OkulBolumlerController : ControllerBase
    {
        IOkulBolumService _okulBolumService;
        public OkulBolumlerController(IOkulBolumService okulBolumService)
        {
            _okulBolumService = okulBolumService;
        }
        [HttpPost("addreturnokulbolumid")]
        public IActionResult AddReturnOkulBolumId(OkulBolum okulBolum)
        {
            var result = _okulBolumService.AddReturnOkulBolumId(okulBolum);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallokulbolumbyokulid")]
        public IActionResult GetAllOkulBolumByOkulId(int okulId)
        {
            var result = _okulBolumService.GetAllOkulBolumlerByOkulId(okulId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

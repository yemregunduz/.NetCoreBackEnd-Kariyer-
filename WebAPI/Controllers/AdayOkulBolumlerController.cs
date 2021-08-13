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
    public class AdayOkulBolumlerController : ControllerBase
    {
        IAdayOkulBolumService _adayOkulBolumService;
        public AdayOkulBolumlerController(IAdayOkulBolumService adayOkulBolumService)
        {
            _adayOkulBolumService = adayOkulBolumService;
        }
        [HttpGet("getallbyadayid")]
        public IActionResult GetAllByAdayId(int adayId)
        {
            var result = _adayOkulBolumService.GetAllByAdayId(adayId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalladayokulbolumdtobyadayid")]
        public IActionResult GetAllAdayOkulBolumDtoByAdayId(int adayId)
        {
            var result = _adayOkulBolumService.GetAllAdayOkulBolumDto(adayId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(AdayOkulBolum adayOkulBolum)
        {
            var result = _adayOkulBolumService.Add(adayOkulBolum);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

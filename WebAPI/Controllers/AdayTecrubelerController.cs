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
    public class AdayTecrubelerController : ControllerBase
    {
        IAdayTecrubeService _adayTecrubeService;
        public AdayTecrubelerController(IAdayTecrubeService adayTecrubeService)
        {
            _adayTecrubeService = adayTecrubeService;
        }
        [HttpPost("add")]
        public IActionResult Add(AdayTecrube adayTecrube)
        {
            var result = _adayTecrubeService.Add(adayTecrube);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(AdayTecrube adayTecrube)
        {
            var result = _adayTecrubeService.Update(adayTecrube);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(AdayTecrube adayTecrube)
        {
            var result = _adayTecrubeService.Delete(adayTecrube);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalladaytecrubedetaydtobyadayid")]
        public IActionResult GetAllAdayTecrubeDetayDtoByAdayId(int adayId)
        {
            var result = _adayTecrubeService.GetAllDetayTecrubeDtoByAdayId(adayId);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getadaytecrubebyid")]
        public IActionResult GetAdayTecrubeById(int id)
        {
            var result = _adayTecrubeService.GetByAdayTecrubeId(id);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

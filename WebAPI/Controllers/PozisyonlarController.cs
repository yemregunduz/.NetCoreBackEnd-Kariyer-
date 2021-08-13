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
    public class PozisyonlarController : ControllerBase
    {
        IPozisyonService _pozisyonService;
        public PozisyonlarController(IPozisyonService pozisyonService)
        {
            _pozisyonService = pozisyonService;
        }
        [HttpPost("add")]
        public IActionResult Add(Pozisyon pozisyon)
        {
            var result = _pozisyonService.Add(pozisyon);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Pozisyon pozisyon)
        {
            var result = _pozisyonService.Delete(pozisyon);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Pozisyon pozisyon)
        {
            var result = _pozisyonService.Update(pozisyon);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _pozisyonService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbypozisyonid")]
        public IActionResult GetByPozisyonId(int id)
        {
            var result = _pozisyonService.GetByPozisyonId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

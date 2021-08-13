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
    public class OkullarController : ControllerBase
    {
        IOkulService _okulService;
        public OkullarController(IOkulService okulService)
        {
            _okulService = okulService;
        }
        [HttpPost("add")]
        public IActionResult Add(Okul okul)
        {
            var result = _okulService.Add(okul);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Okul okul)
        {
            var result = _okulService.Delete(okul);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Okul okul)
        {
            var result = _okulService.Update(okul);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _okulService.GetAll();
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyokulid")]
        public IActionResult GetByOkulId(int id)
        {
            var result = _okulService.GetByOkulId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

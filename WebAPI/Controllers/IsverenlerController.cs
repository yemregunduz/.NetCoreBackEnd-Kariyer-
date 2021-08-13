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
    public class IsverenlerController : ControllerBase
    {
        IIsverenService _isverenService;
        public IsverenlerController(IIsverenService isverenService)
        {
            _isverenService = isverenService;
        }
        [HttpPost("add")]
        public IActionResult Add(Isveren isveren)
        {
            var result = _isverenService.Add(isveren);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Isveren isveren)
        {
            var result = _isverenService.Delete(isveren);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Isveren isveren)
        {
            var result = _isverenService.Update(isveren);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _isverenService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("geybyisverenid")]
        public IActionResult GetByIsverenId(int id)
        {
            var result = _isverenService.GetByIsverenId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("geybyisverenid")]
        public IActionResult GetByMail(string email)
        {
            var result = _isverenService.GetByEmail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("getallisverendetaydto")]
        public IActionResult GetAllIsverenDetayDto()
        {
            var result = _isverenService.GetAllIsverenDetayDto();
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getisverendetaydtobyisverenid")]
        public IActionResult GetIsverenDetayDtoByIsverenId(int isverenId)
        {
            var result = _isverenService.GetIsverenDetayDtoByIsverenId(isverenId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallisverendetaydtobysehirid")]
        public IActionResult GetAllIsverenDetayDtoBySehirId(int sehirId)
        {
            var result = _isverenService.GetAllIsverenBySehirId(sehirId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

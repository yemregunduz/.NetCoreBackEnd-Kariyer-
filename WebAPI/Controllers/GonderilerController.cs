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
    public class GonderilerController : ControllerBase
    {
        IGonderiService _gonderiService;
        public GonderilerController(IGonderiService gonderiService)
        {
            _gonderiService = gonderiService;
        }
        [HttpPost("add")]
        public IActionResult Add(Gonderi gonderi)
        {
            var result = _gonderiService.Add(gonderi);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Gonderi gonderi)
        {
            var result = _gonderiService.Delete(gonderi);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Gonderi gonderi)
        {
            var result = _gonderiService.Update(gonderi);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _gonderiService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbygonderiid")]
        public IActionResult GetByGonderiId(int gonderiId)
        {
            var result = _gonderiService.GetByGonderiId(gonderiId);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalladaygonderidetaydto")]
        public IActionResult GetAllAdayGonderiDetayDto(int takipEdilenId,int startIndex, int countOfQuery)
        {
            var result = _gonderiService.GetAllAdayGonderiDetayDto(takipEdilenId,startIndex, countOfQuery);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalladaygonderidetaydtobyadayid")]
        public IActionResult GetAllAdayGonderiDetayDtoByAdayId(int startIndex, int countOfQuery, int adayId)
        {
            var result = _gonderiService.GetAllAdayGonderiDetayDtoByAdayId(startIndex,countOfQuery,adayId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

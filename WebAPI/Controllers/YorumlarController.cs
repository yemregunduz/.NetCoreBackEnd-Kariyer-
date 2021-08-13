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
    public class YorumlarController : ControllerBase
    {
        IYorumService _yorumService;
        public YorumlarController(IYorumService yorumService)
        {
            _yorumService = yorumService;
        }
        [HttpPost("add")]
        public IActionResult Add(Yorum yorum)
        {
            var result = _yorumService.Add(yorum);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Yorum yorum)
        {
            var result = _yorumService.Delete(yorum);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Yorum yorum)
        {
            var result = _yorumService.Update(yorum);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _yorumService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallyorumdetaydtobygonderiid")]
        public IActionResult GetAllAdayGonderiDetayDto(int gonderiId)
        {
            var result = _yorumService.GetAllYorumDetayDtoByGonderiId(gonderiId);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

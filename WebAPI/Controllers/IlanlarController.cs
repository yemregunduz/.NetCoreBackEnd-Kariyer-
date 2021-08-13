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
    public class IlanlarController : ControllerBase
    {
        IIlanService _ilanService;
        public IlanlarController(IIlanService ilanService)
        {
            _ilanService = ilanService;
        }
        [HttpPost("add")]
        public IActionResult Add(Ilan ilan)
        {
            var result = _ilanService.Add(ilan);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Ilan ilan)
        {
            var result = _ilanService.Delete(ilan);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Ilan ilan)
        {
            var result = _ilanService.Update(ilan);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _ilanService.GetAll();
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyilanid")]
        public IActionResult GetByIlanId()
        {
            var result = _ilanService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallilanbypozisyonid")]
        public IActionResult GetAllIlanByPozisyonId(int pozisyonId)
        {
            var result = _ilanService.GetAllByPozisyonId(pozisyonId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
       [HttpGet("getallilandetaydto")]
       public IActionResult GetAllIlanDetayDto()
        {
            var result = _ilanService.GetAllIlanDetayDto();
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallilandetaydtobypozisyonid")]
        public IActionResult GetAllIlanDetayDtoByPozisyonId(int pozisyonId)
        {
            var result = _ilanService.GetAllIlanDetayDtoByPozisyonId(pozisyonId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallilandetaydtobysearchparameters")]
        public IActionResult GetAllIlanDetayDtoBySearchParameters(int? sehirId=null,int? pozisyonId=null, int? isverenId=null )
        {   
            var result = _ilanService.GetAllIlanDetayDtoBySearchParameters(sehirId,pozisyonId,isverenId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        

    }
}

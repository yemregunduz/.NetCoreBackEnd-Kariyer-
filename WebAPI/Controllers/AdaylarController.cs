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
    public class AdaylarController : ControllerBase
    {
        IAdayService _adayService;
        public AdaylarController(IAdayService adayService)
        {
            _adayService = adayService;
        }
        [HttpPost("add")]
        public IActionResult Add(Aday aday)
        {
            var result = _adayService.Add(aday);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Aday aday)
        {
            var result = _adayService.Delete(aday);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Aday aday)
        {
            var result = _adayService.Update(aday);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _adayService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyemail")]
        public IActionResult GetByEmail(string email)
        {
            var result = _adayService.GetByMail(email);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetByAdayId(int id)
        {
            var result = _adayService.GetByAdayId(id);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getadaycvtecrubedtobyadayid")]
        public IActionResult GetAdayCvTecrubeDtoByAdayId(int adayId)
        {
            var result = _adayService.GetAdayByAdayId(adayId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updateadayiletisimbilgileri")]
        public IActionResult UpdateAdayIletisimBilgileri(Aday aday)
        {
            var result = _adayService.UpdateAdayIletisimBilgileri(aday);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updateadaysosyalmedyabilgileri")]
        public IActionResult UpdateAdaySosyalMedyaBilgileri(Aday aday)
        {
            var result = _adayService.UpdateAdaySosyalMedyaBilgileri(aday);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("searchadaylarbyfiltertext")]
        public IActionResult SearchAdaylarByFilterText(string filterText)
        {
            var result = _adayService.GetAllAdaylarBySearchFilter(filterText);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updateprofilephoto")]
        public IActionResult UpdateProfilePhoto(Aday aday)
        {
            var result = _adayService.UpdateProfilePhoto(aday);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}

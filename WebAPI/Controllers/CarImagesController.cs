﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        
           [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage images)
        {
            var result = _carImageService.Add(file, images);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromForm ( Name = ("Image"))] IFormFile file , [FromForm] CarImage carImage)

            {
            var result = _carImageService.Delete(carImage);
                if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if(result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carImageService.GetById(id);
            if(result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }

        [HttpPost("update")]
        public IActionResult Update([FromForm (Name = ("Image   "))] IFormFile file , [FromForm] CarImage carImage )

        {
            var result = _carImageService.Update(file, carImage);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);




        }


    }
}

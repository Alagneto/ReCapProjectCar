﻿using Core.DataAccess.Results;
using Core.DataAccess.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IDataResult<List<CarImage>> GetById(int Id);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> Get(int Id);



    }
}

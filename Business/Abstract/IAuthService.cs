﻿using Core.DataAccess.Results;
using Core.DataAccess.Utilities.Results;
using Core.Entity.Concrete;
using Core.Utilities.Security.Jwt;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface  IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto , string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExist(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}

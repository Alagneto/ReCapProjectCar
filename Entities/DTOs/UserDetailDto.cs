﻿using Core.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class UserDetailDto : IDto
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
    }
}

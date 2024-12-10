﻿using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IJwtService
    {
        string CreateToken(IEnumerable<Claim> claims);
        IEnumerable<Claim> GetClaims(User user);
    }
}

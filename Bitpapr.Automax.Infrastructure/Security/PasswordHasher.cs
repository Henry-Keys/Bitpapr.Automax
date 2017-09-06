﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitpapr.Automax.Infrastructure.Security
{
    public class PasswordHasher
    {
        public string HashPassword(string password)
        {
            var hash = BCrypt.Net.BCrypt.HashPassword(password);
            return string.IsNullOrEmpty(password) ? string.Empty : hash;
        }
    }
}
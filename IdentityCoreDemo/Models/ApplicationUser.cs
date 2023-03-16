﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCoreDemo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Models
{
    public class CustomRoleViewModel:IdentityRole
    {
        public override string Id { get; set; }
    }
}

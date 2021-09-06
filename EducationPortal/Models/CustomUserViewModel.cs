using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Models
{
    public class CustomUserViewModel:IdentityUser
    {
       
        [PersonalData]
        public override string Id { get; set; }

        bool type = false;
        [PersonalData]
        public bool EducatorType { get { return type; } set { type = false; } }

    }
}

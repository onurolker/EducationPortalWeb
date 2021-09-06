using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Models
{
    public class EducationUsersAndEducation
    {
        [Key]
        public int Id { get; set; }

        bool defaultjoin;
        public bool RequestJoin { get { return defaultjoin; } set { defaultjoin = false; } }
        public EducationViewModel EducationViewModel { get; set; }
        public int EducationViewModelId { get; set; }

        public CustomUserViewModel CustomUserViewModel { get; set; }
        public int CustomUserViewModelId { get; set; }
    }
}

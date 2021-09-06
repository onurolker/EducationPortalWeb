using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Models
{
    public class EducationViewModel
    {

        public EducationViewModel()
        {
            EducationDetailsViewModels = new List<EducationDetailsViewModel>();
            EducationUsersAndEducation = new List<EducationUsersAndEducation>();
        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Eğitim Adı")]
        [Required]
        [MinLength(3, ErrorMessage = "Minimum Lenght {1}")]
        [MaxLength(200, ErrorMessage = "Maximum Lenght {1}")]
        public string EducationName { get; set; }


        public IEnumerable<EducationDetailsViewModel> EducationDetailsViewModels { get; set; }
        public IEnumerable<EducationUsersAndEducation> EducationUsersAndEducation { get; set; }

        public EducationCategoriesViewModel EducationCategoriesViewModel { get; set; }
        [Display(Name = "Kategori")]
        public int EducationCategoriesViewModelId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Models
{
    public class EducationCategoriesViewModel
    {
        public EducationCategoriesViewModel()
        {
            EducationViewModels = new List<EducationViewModel>();
        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Kategori Adı")]
        [Required]
        [MinLength(3, ErrorMessage = "Minimum Lenght {1}")]
        [MaxLength(50, ErrorMessage = "Maximum Lenght {1}")]
        public string CategoryName { get; set; }

        public IEnumerable<EducationViewModel> EducationViewModels { get; set; }
    }
}

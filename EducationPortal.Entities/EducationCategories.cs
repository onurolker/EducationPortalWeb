using EducationPortal.Models;
using System.Collections.Generic;

namespace EducationPortal.Entities
{
    public class EducationCategories
    {
        public EducationCategories()
        {
         EducationViewModels = new List<EducationViewModel>();
        }
        
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public IEnumerable<EducationViewModel> EducationViewModels { get; set; }

    }
}

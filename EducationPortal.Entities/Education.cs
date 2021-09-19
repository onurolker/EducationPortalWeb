using EducationPortal.Models;
using System.Collections.Generic;

namespace EducationPortal.Entities
{
    public class Education {
        public Education()
        {
            EducationDetailsViewModels = new List<EducationDetailsViewModel>();
            EducationUsersAndEducation = new List<EducationUsersAndEducation>();
        }
        public int Id { get; set; }
        public string EducationName { get; set; }
        public IEnumerable<EducationDetailsViewModel> EducationDetailsViewModels { get; set; }
        public IEnumerable<EducationUsersAndEducation> EducationUsersAndEducation { get; set; }

        public EducationCategoriesViewModel EducationCategoriesViewModel { get; set; }
      
        public int EducationCategoriesViewModelId { get; set; }

    }
}

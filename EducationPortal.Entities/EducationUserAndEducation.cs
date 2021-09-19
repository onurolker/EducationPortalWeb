using EducationPortal.Models;

namespace EducationPortal.Entities
{
    public class EducationUserAndEducation {
        public int Id { get; set; }

        bool defaultjoin;
        public bool RequestJoin { get { return defaultjoin; } set { defaultjoin = false; } }
        public EducationViewModel EducationViewModel { get; set; }
        public int EducationViewModelId { get; set; }

        public CustomUserViewModel CustomUserViewModel { get; set; }
        public int CustomUserViewModelId { get; set; }
    }
}

using EducationPortal.Models;
using System;

namespace EducationPortal.Entities
{
    public class EducationDetails {

        public int Id { get; set; }
        public string EducationDetailFilePath { get; set; }
        public decimal EducationDetailDailyPrice { get; set; }
        public int EducationDetailQuota { get; set; }
        public TimeSpan EducationDetailTotalTime { get; set; }
        public EducationViewModel EducationViewModel { get; set; }
        public int EducationViewModelId { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Models
{
    public class EducationDetailsViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Dosya Yolu")]
        [Required]
        [MinLength(3, ErrorMessage = "Minimum Lenght {1}")]
        [MaxLength(1000, ErrorMessage = "Maximum Lenght {1}")]
        public string EducationDetailFilePath { get; set; }
        [Required]
        [Display(Name = "Fiyat")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal EducationDetailDailyPrice { get; set; }
        [Display(Name = "Kota")]
        public int EducationDetailQuota { get; set; }
        [Required]
        [Display(Name = "Süre")]
        [DataType("Time")]
        public TimeSpan EducationDetailTotalTime { get; set; }

        public EducationViewModel EducationViewModel { get; set; }
        public int EducationViewModelId { get; set; }

    }
}

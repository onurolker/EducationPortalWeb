using EducationPortal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Data.Mapping
{
    public class EducationDetailsViewModelMapping : IEntityTypeConfiguration<EducationDetailsViewModel>
    {
        public void Configure(EntityTypeBuilder<EducationDetailsViewModel> builder)
        {
            builder.Property(b => b.EducationDetailDailyPrice).HasColumnType("Money");      // needs entityframework.relation library

        }
    }
}

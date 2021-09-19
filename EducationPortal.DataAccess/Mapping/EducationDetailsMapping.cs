using EducationPortal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationPortal.DataAccess.Mapping
{
    class EducationDetailsMapping : IEntityTypeConfiguration<EducationDetails>
    {
        public void Configure(EntityTypeBuilder<EducationDetails> builder)
        {
            builder.Property(b => b.EducationDetailDailyPrice).HasColumnType("Money");      // needs entityframework.relation library

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw11.Configurations
{
    public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(e => e.IdPrescription);

            builder.Property(e => e.Date)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(e => e.DueDate)
                   .HasColumnType("date")
                   .IsRequired();
        }
    }
}

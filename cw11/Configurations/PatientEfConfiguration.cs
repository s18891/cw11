using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw11.Configurations
{
    public class PatientEfConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(e => e.IdPatient);

            builder.Property(e => e.FirstName)
                   .IsRequired();

            builder.Property(e => e.LastName)
                   .IsRequired();

            builder.Property(e => e.Birthdate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.HasMany(e => e.Prescriptions)
                   .WithOne(p => p.Patient)
                   .HasForeignKey(p => p.IdPatient);
        }
    }
}

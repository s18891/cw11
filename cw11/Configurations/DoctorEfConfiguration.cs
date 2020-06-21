using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw11.Configurations
{
    public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(e => e.IdDoctor);

            builder.Property(e => e.FirstName)
                   .IsRequired();

            builder.Property(e => e.LastName)
                   .IsRequired();

            builder.Property(e => e.Email)
                   .IsRequired();

            builder.HasMany(e => e.Prescriptions)
                  .WithOne(p => p.Doctor)
                  .HasForeignKey(p => p.IdDoctor);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw11.Configurations
{
    public class MedicamentEfConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(e => e.IdMedicament);

            builder.Property(e => e.Name)
                   .IsRequired();

            builder.Property(e => e.Description)
                   .IsRequired();

            builder.Property(e => e.Type)
                   .IsRequired();
        }
    }
}

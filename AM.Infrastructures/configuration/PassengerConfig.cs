using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructures.configuration
{

    public class PassengerConfig : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p => p.FullName,
                full =>
                {
                    full.Property(f => f.FirstName)
                .HasMaxLength(30)
                .HasColumnName("Name");
                    full.Property(f => f.LastName)
                .IsRequired();
                }
            );
        }
    }

}
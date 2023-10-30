using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructures.configuration
{
    public class FlightConfig : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {

            //renommer la table associative entre Flight & Passenger    //many to many

           builder.HasMany(f => f.Passengers)    
                .WithMany(p => p.Flights)
                .UsingEntity(tab=> tab.ToTable("VolsPassenger"));   //renommer table associative



            builder
              .HasOne(f => f.Plane)
              .WithMany(p => p.Flights)
             // .HasForeignKey(f => f.PlaneFK)
              .OnDelete(DeleteBehavior.Cascade); //fk with delete cascade
        }
    }
}

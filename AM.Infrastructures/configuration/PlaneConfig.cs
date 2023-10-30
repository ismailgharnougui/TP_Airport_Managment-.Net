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
    public class PlaneConfig : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {

            builder.HasKey(p => p.PlaneId);  //key
            //changer nom de table 
            builder.ToTable("MyPlanes");
            //changer nom de colonne 
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity");




            //builder
            //  .HasMany(f => f.Flights)
            //  .WithOne(p => p.Plane)
            // //  .HasForeignKey(f => f.PlaneFK)
            //  .OnDelete(DeleteBehavior.SetNull); //fk with delete cascade




        }
    }
}

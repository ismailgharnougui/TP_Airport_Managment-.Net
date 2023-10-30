using AM.ApplicationCore.Domain;
using AM.Infrastructures.configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructures
{// 1 ajout de la classe DbContext

    //2 installation d'un ORM :: Entity Framework
    public class AMContext : DbContext
    {

        //3 - Quelles sont les entités qui vont etre des tables
        // au niveau de BD  =>DbSet<Entity>Table

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ReservationTicket> ReservationTickets { get; set; }

        // 4 -chaine de cnx
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ISMAEL\SQLEXPRESS;
    Initial Catalog=AirportM-4ERP-BI1;Integrated Security=true;
    User ID=ISMAEL; Password=ismael150;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        //Appel des class de Config FluentAPI "overide on"
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfig());
            modelBuilder.ApplyConfiguration(new FlightConfig());
            modelBuilder.ApplyConfiguration(new ReservationConfig());

            modelBuilder.Entity<Passenger>().OwnsOne(p => p.FullName, Full =>
            {
                Full.Property(x => x.FirstName);
                Full.Property(x => x.LastName);

            });

            //configuration de TPH : l'approche par défaut de l'héritage
            modelBuilder.Entity<Passenger>()
                .HasDiscriminator<int>("PassengerType")
                .HasValue<Passenger>(1)
                .HasValue<Traveller>(2)
                .HasValue<Staff>(3);
            //avec caractere 
        /*    modelBuilder.Entity<Passenger>()
               .HasDiscriminator<char>("PassengerType")
               .HasValue<Passenger>('P')
               .HasValue<Traveller>('T')
               .HasValue<Staff>('S');*/

            /*  modelBuilder.Entity<Ticket>().HasMany(T => T.ReservationTickets)
                  .WithOne(t => t.ticket)
                  .HasForeignKey(x => x.ticket);
              modelBuilder.Entity<ReservationTicket>()
                  .HasOne(t => t.ticket)
                  .WithMany(P => P.ReservationTickets)
                  .HasForeignKey(x => x.ticket);*/

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Staff>().ToTable("Staffs");
            modelBuilder.Entity<Traveller>().ToTable("Travellers");
        }

        //pre convantion 

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("Date");
            ConfigureConventions(configurationBuilder);
        }
    }
}

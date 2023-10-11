using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructures
{// 1 ajout de la classe DbContext

    //2 installation d'un ORM :: Entity Framework
    public  class AMContext :DbContext
    {

        //3 - Quelles sont les entités qui vont etre des tables
        // au niveau de BD  =>DbSet<Entity>Table

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }


        // 4 -chaine de cnx
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=AirportM-4ERP-BI;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

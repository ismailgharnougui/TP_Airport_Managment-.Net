using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.Infrastructures.configuration
{

    internal class ReservationConfig : IEntityTypeConfiguration<ReservationTicket>
    {
        public void Configure(EntityTypeBuilder<ReservationTicket> builder)
        {
            
            builder.HasKey(p => new { p.PassengerFK,
                p.TicketFK ,    
            p.DateReservation});
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class ReservationTicket
    {
        public DateTime DateReservation { get; set; }
        public Double Prix { get; set; }



        [ForeignKey("Passenger")]
        public int PassengerFK { get; set; }


        [ForeignKey("Ticket")]
        public int TicketFK { get; set; }

//[ForeignKey("PassengerFK")]
        public Passenger Passenger { get; set; }
      //  [ForeignKey("TicketFk")]
        public Ticket Ticket { get; set; }


    }
}

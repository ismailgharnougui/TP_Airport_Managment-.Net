using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {

        
        public int Id { get; set; }

        public string Classe { get; set; }

        public string Destination { get; set; }

        public IList<ReservationTicket> ReservationTickets { get; set; }


    }

}
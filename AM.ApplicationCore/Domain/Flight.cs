using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {

        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }

     
        public  IList<Passenger> Passengers { get; set; }

        //cle etrangere 
        //renomer cle etrangere nomFK

        //1 - declater prop qui porte le meme type de la clé primaire (planeID)


        // 2 methodes  pour declarer 3aks b3adhhom 
        [ForeignKey("Plane")]
        public int PlaneFK { get; set; }
      // ou bien   [ForeignKey("PlaneFK")]
        public Plane Plane { get; set; }

      
    }
}

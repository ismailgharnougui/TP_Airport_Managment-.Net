using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{


    public class Flightmethod : IFlightMethod
    {
        public IList<Flight> Flights { get; set; } = new List<Flight>();

        public IList<DateTime> GetFlightDate(string destination)
        {//methode classique
            //IList<DateTime> result = new List<DateTime>();

            //foreach (var flight in Flights)
            //{
            //    if (flight.Destination == destination)

            //        result.Add((flight.FlightDate));

            //}
            //return result;

            //langage linq

            var query = from flight in Flights
                        where flight.Destination == destination
                        select flight.FlightDate;

            return query.ToList();

        }

        public void ShowFlightDetails(Plane plane)
        {
            var query = from flight in Flights
                      where flight.Plane == plane
                      select new { flight.Destination, flight.FlightDate };

            //var query = from flight in plane.Flights
            //            //    select flight.FlightDate + flight.Destination;
            //            select new { flight.Destination, flight.FlightDate };
            foreach (var a in query)
            {
                Console.WriteLine("flight date" + a.FlightDate + "destination" + a.Destination);
            }
        }

        public int ProgrammedFlightNumber(DateTime startDate)

        {
            //DateTime endDate = startDate.AddDays(7);
            //var query = from f in Flights

            //           //where (f.FlightDate) >= startDate && (f.FlightDate <= endDate);
            //return query.Count();
            var query = from f in Flights
                        where DateTime.Compare(f.FlightDate, startDate) > 0 && (f.FlightDate - startDate).TotalDays < 7
                        select f;
            return query.Count();
        }
        public double DurationAverage(string destination)
        {//linq
         //var query = from flight in Flights
         //            where flight.Destination == destination
         //            select flight.EstimatedDuration;
         // return query.Average();

            //lambda
            // return Flights.Where(A => A.Destination.Equals(destination)).Select(A => A.EstimatedDuration).Average();
            return Flights.Where(A => A.Destination.Equals(destination)).Average(A => A.EstimatedDuration);
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            //linq 

            //var query = from f in Flights
            //            orderby f.EstimatedDuration descending
            //          select f;
            //return query;

            //lambda
            return Flights.OrderByDescending(f => f.EstimatedDuration);

        }

        public IEnumerable<Traveller> SeniorTravellers(Flight f1)
        {
            //linq 
            //var query = from f in f1.Passengers.OfType<Traveller>()
            //            orderby f.BirthDate
            //            select f;
            //return query.Take(3);

            //lambda

            return f1.Passengers.OfType<Traveller>().OrderBy(A=>A.BirthDate).Take(3);


        }

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            //linq
            var query = from f in Flights
                        group f by f.Destination;
            foreach (var a in query)
            { Console.WriteLine("Destination   " + a.Key);
                foreach (var b in a)
                { Console.WriteLine("decollage   "+b.FlightDate); }
            }
            return query;
        }
    }
}



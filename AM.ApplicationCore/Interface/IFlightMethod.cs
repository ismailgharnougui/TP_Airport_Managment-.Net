using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interface
{
    internal interface IFlightMethod
    {
        IList<DateTime> GetFlightDate(string Destination);

        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
       IEnumerable<Flight>OrderedDurationFlights();
        IEnumerable<Traveller> SeniorTravellers(Flight flight);
        IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
    }
}

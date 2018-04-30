using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Models;

namespace Airport.Controller
{
    class FlightController : IFlightController
    {

        private static List<Flight> flights = new List<Flight>();
      
        public void addNewFlight(Flight flight)
        {
            flights.Add(flight);
        }

        public void getAllFlights()
        {
            foreach (var flight in flights)
            {
                Console.WriteLine("Flight number {0} in Origin {1} and Destination is {2} Date is {3}",
                    flight.Id, flight.Origin, flight.Destination, flight.Date);
            }
        }

        
    }
}

using Airport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Controller
{
    interface IFlightController
    {
        void addNewFlight(Flight flight);
        void getAllFlights();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Models
{
    class Customer
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = Guid.NewGuid().ToString(); }
        }

        public string Name { get; set; }
        public int FlightId { get; set; }

        public Customer() { }
        public Customer(string name, int flightId)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = name;
            this.FlightId = flightId;
        }
    }
}

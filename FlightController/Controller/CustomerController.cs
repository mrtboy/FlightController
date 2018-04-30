using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Models;

namespace Airport.Controller
{
    class CustomerController : ICustomerController
    {
        private static List<Customer> customers = new List<Customer>();
        public void getAllCustomer()
        { 
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer {0} is on flight Number {1}", 
                    customer.Name, customer.FlightId);
            }
        }
        public void addNewCustomer(Customer customer)
        {
            customers.Add(customer);

        }
        public void flightInformation(int number)
        {
            foreach (var customer in customers)
            {
                if (customer.FlightId == number)
                {
                    Console.WriteLine("Customer is {0} is on flight Number {1}", customer.Name, customer.FlightId);
                }
            }
        }

        public void getCustomerByName(string name)
        {
            foreach (var customer in customers)
            {
                if (customer.Name.Equals(name))
                {
                    Console.WriteLine("Customer is {0} is on flight Number {1}", customer.Name, customer.FlightId);
                }
            }
        }
    }
}

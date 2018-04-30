using Airport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Controller
{
    interface ICustomerController
    {
        void flightInformation(int number);
        void getAllCustomer();
        void addNewCustomer(Customer _customer);
        void getCustomerByName(string name);
    }
}

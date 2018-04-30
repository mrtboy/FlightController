using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Models;

namespace Airport.Controller
{
    class ClientController
    {
        ICustomerController customerController;
        IFlightController flightController;

        public ClientController() {
            customerController = new CustomerController();
            flightController = new FlightController();
        }
       
        public void mainMenu()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Weblcom To Flight Controll Management");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. Show all Flights.");
            Console.WriteLine("2. Show all Customers.");
            Console.WriteLine("3. Find Customer.");
            Console.WriteLine("4. Find Flight.");
            Console.WriteLine("5. Add new Customer.");
            Console.WriteLine("6. Add new Flight.");
            Console.WriteLine("7. Quiet.");
                

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    showFlightsMenu();
                    break;
                case "2":
                    showCustomersMenu();
                    break;
                case "3":
                    findCustomerMenu();
                    break;
                case "4":
                    findFlightMenu();
                    break;
                case "5":
                    addNewCustomerMenu();
                    break;
                case "6":
                    addNewFlight();
                    break;
                case "7":
                    break;
                default:
                    Console.WriteLine("Wrong Option");
                    break;
            }

        }

        private void addNewFlight()
        {
            Console.WriteLine("Add New flight.");
            Console.WriteLine("================");
            Console.WriteLine("Flight Number: ");
            int flightNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Origin: ");
            string origin = Console.ReadLine();
            Console.WriteLine("Destination: ");
            string destination = Console.ReadLine();
            Console.WriteLine("Date");
            string date = Console.ReadLine();
            Flight flight = new Flight(flightNumber, origin, destination,date);
            flightController.addNewFlight(flight);
            Console.WriteLine();
            mainMenu();
        }

        private void showFlightsMenu()
        {
            flightController = new FlightController();
            Console.WriteLine("Current Flights.");
            Console.WriteLine("======================");
            flightController.getAllFlights();
            Console.WriteLine();
            mainMenu();

        }

        private void addNewCustomerMenu()
        {
            Console.WriteLine("Register New customer.");
            Console.WriteLine("======================");
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Customer Flight Number: ");
            
            int flightId = Convert.ToInt32(Console.ReadLine());
            Customer customer = new Customer(name, flightId);
            customerController.addNewCustomer(customer);
            Console.WriteLine();
            mainMenu();
        }

        private void showCustomersMenu()
        {
            customerController = new CustomerController();
            Console.WriteLine("List of Customers.");
            Console.WriteLine("======================");
            customerController.getAllCustomer();
            Console.WriteLine();
            mainMenu();
        }

        private void findCustomerMenu()
        {
            customerController = new CustomerController();
            Console.WriteLine("Finding Customer by customer Name.");
            Console.WriteLine("==================================");
            Console.Write("Customer Name: ");
            string customerName = Console.ReadLine();
            customerController.getCustomerByName(customerName);
            Console.WriteLine();
            mainMenu();
        }


        private void findFlightMenu()
        {
            customerController = new CustomerController();
            Console.WriteLine("Finding flight by flight Number.");
            Console.WriteLine("==================================");
            Console.Write("Flight Number: ");
            int flightNumber = Convert.ToInt32(Console.ReadLine());
            customerController.flightInformation(flightNumber);
            Console.WriteLine();
            mainMenu();
        }
    }
}

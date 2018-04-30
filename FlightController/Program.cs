using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Models;
using Airport.Controller;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {

        
            ClientController clientController = new ClientController();
            clientController.mainMenu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;
using Test.Veiw;

namespace Test.Controllers
{
    public class DestinationController
    {
        private Display display;
        private Destination destination;

        public DestinationController()
        {
            display = new Display();
            destination = new Destination(display.Byudjet, display.Sezon);
            display.TotalPrice = destination.CalculatingByudjet();
            display.Place = destination.CampOrHotel();
            display.ShowPrice();
        }
    }
}

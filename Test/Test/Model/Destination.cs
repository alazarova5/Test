using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model
{
    public class Destination
    {
        private int byudjet;
        private string sezon;

        public Destination(int byudjet,string sezon)
        {
            this.Byudjet = this.byudjet;
            this.Sezon = sezon;
        }
        public int Byudjet { get; set; }
        public string Sezon { get; set; }

        public int CalculatingByudjet()
        {
            int price = 0;
            string destination = "";
            if (byudjet<=100)
            {
                if (destination=="Bulgaria")
                {
                    if (sezon == "summer")
                    {
                        price = byudjet * 30 / 100;
                        return price;
                    }
                    else if (sezon == "winter")
                    {
                        price = byudjet * 70 / 100;
                        return price;
                    }
                }
            }
            if (byudjet<=1000)
            {
                if (sezon == "summer")
                {
                    if (destination == "Balkans")
                    {
                        price = byudjet * 40 / 100;
                        return price;
                    }
                    else if (sezon == "winter")
                    {
                        price = byudjet * 80 / 100;
                        return price;
                    }
                }
            }
            if (byudjet>1000)
            {
                if (destination=="Europe")
                {
                    price = byudjet * 90 / 100;
                    return price;
                }
            }
            return price;
        }

        public string CampOrHotel()
        {
            string result = "";
            string destination = "";
            if (destination == "Europe")
            {
                result = "Hotel";
                return result;
            }
            else if (destination == "Balkans")
            {
                if (sezon == "summer")
                {
                    result = "Camp";
                    return result;
                }
                else if (sezon == "winter")
                {
                    result = "Hotel";
                    return result;
                }
            }
            else if (destination == "Bulgaria")
            {
                if (sezon == "summer")
                {
                    result = "Camp";
                    return result;
                }
                else if (sezon == "winter")
                {
                    result = "Hotel";
                    return result;
                }
            }
            return result;
        }
    }
}

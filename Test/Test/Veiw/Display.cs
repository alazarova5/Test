using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Veiw
{
    public class Display
    {
        private string place;
        private int totalPrice;

        public Display()
        {
            this.Byudjet = 0;
            this.Sezon = "";
            this.Place = "";
            this.TotalPrice = 0;
            this.GetValues();
        }

        public int Byudjet { get; set; }
        public string Sezon { get; set; }
        public string Place 
        {
            
            get { return this.place; }
            set
            {
                string input = Console.ReadLine();
                switch(input)
                {
                    case "Bulgaria":
                        {
                            Console.WriteLine("Somewhere in Bulgaria");
                            ShowPrice();
                            break;
                        }
                    case "Balkans":
                        { 
                            Console.WriteLine("Somewhere in the Balkans");
                            ShowPrice();
                            break;
                        }
                    case "Europe":
                        {
                            Console.WriteLine("Somewhere in Europe");
                            ShowPrice();
                            break;
                        }
                }
                this.Place = value;
            }
        }
        public int TotalPrice
        {
            get { return this.totalPrice; }
            set { this.totalPrice = value; }
        }

        public void GetValues()
        {
            this.Byudjet = int.Parse(Console.ReadLine());
            this.Sezon = Console.ReadLine();
        }

        public void ShowPrice()
        {
            Console.WriteLine($"{this.Place} - {this.TotalPrice}");
        }
    }
}

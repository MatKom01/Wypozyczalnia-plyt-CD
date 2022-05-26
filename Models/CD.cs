using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektMVC.Models
{
    public class CD
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Lenght { get; set; }
        public string Direction { get; set; }
        public string Scenario { get; set; }
        public string Type { get; set; }
        public string Production { get; set; }
        public string Premiere { get; set; }
        public string Picture { get; set; }


        public CD ()
        {

        }
        public CD (int ID, string Title, double Price, int Lenght, string Direction, string Scenario, string Type, string Production, string Premiere, string Picture)
        {
            this.ID = ID;
            this.Title = Title;
            this.Price = Price;
            this.Lenght = Lenght;
            this.Direction = Direction;
            this.Scenario = Scenario;
            this.Type = Type;
            this.Production = Production;
            this.Premiere = Premiere;
            this.Picture = Picture;
        }
    }

    
}

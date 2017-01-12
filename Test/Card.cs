using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Routing
{
    public class Card
    {
        public string Departure { get; set; }
        public string Destination { get; set; }

        public Card(string departure, string destination)
        {
            Departure = departure;
            Destination = destination;
        }
        public override string ToString()
        {
            return string.Format("{0} > {1}", Departure, Destination);
        }
    }
}

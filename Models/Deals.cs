using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_challenge.Models
{
    public class Deals
    {
        // Controleer of de naam van de eigenschap juist is
        public int Id { get; set; }  // Dit moet precies zo zijn, geen spelfouten.
        public string Header { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class CarouselItem
    {
        // Controleer of de naam van de eigenschap juist is
        public string ImageUrl { get; set; }  // Dit moet precies zo zijn, geen spelfouten.
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

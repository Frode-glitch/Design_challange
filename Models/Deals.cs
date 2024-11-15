using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designchallenge.Models
{
    public partial class Deal
    {
        [JsonProperty("dealID")]
        public long Id { get; set; }

        public string Header { get; set; }

        [JsonProperty("title")]
        public string Name { get; set; }

        [JsonProperty("costs")]
        public long Costs { get; set; }

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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designchallenge.Models
{
    public partial class Parked
    {
        [JsonProperty("currentParked")]
        public int CurrentParked { get; set; }

        [JsonProperty("maxCapacity")]
        public int MaxCapacity { get; set; }
    }

}

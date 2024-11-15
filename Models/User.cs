using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designchallenge.Models
{
	public partial class User
	{
		[JsonProperty("userID")]
		public int UserID { get; set; }

		[JsonProperty("firstName")]
		public string FirstName { get; set; }

		[JsonProperty("lastName")]
		public string LastName { get; set; }

		[JsonProperty("gender")]
		public string Gender { get; set; }

		[JsonProperty("age")]
		public int Age { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("adress")]
		public string Adress { get; set; }

		[JsonProperty("totalPoints")]
		public int TotalPoints { get; set; }

		[JsonProperty("password")]
		public string Password { get; set; }

		[JsonProperty("purchesDate")]
		public string PurchesDate { get; set; }

		[JsonProperty("nfcChip")]
		public string NfcChip { get; set; }
	}

}

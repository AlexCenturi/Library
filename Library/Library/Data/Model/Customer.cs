using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Model
{
    public class Customer
    {
		public int Id { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string SSN { get; set; }
		[Required]
		public string Street { get; set; }
		[Required]
		public string Pcode { get; set; }
		[Required]
		public string City { get; set; }
		[Required]
		public string Phone { get; set; }
	}
}

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
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string SSN { get; set; }
		public string Street { get; set; }
		public string Pcode { get; set; }
		public string City { get; set; }
		public string Phone { get; set; }
	}
}

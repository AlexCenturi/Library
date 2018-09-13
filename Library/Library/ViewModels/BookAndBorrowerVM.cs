using Library.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.ViewModels
{
	public class BookAndBorrowerViewModel
	{
		public int Id { get; set; }
		public Book Book { get; set; }
		public Customer Customer { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime ReturnDate { get; set; }
	}
}

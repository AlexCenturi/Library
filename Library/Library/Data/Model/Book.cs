using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Model
{
	public class Book
	{
		public int Id { get; set; }
		public string ISBN { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		//public byte Cover { get; set; }
		//public string Description { get; set; }

	}
}

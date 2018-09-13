using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Model
{
	public class Book
	{

		public int Id { get; set; }

		[Required]
		public string ISBN { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Author { get; set; }
		//public byte Cover { get; set; }
		//public string Description { get; set; }

	}
}

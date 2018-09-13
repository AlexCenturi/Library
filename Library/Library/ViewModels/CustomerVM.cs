using Library.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.ViewModels
{
    public class CustomerVM
    {
		public Customer Customer { get; set; }
		public List<Book> BookList { get; set; }
	}
}

using Library.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.ViewModels
{
    public class BookVM
    {
		public Book Book { get; set; }
		public bool Available { get; set; }
    }
}

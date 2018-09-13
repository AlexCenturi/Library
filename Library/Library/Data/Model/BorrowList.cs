using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Model
{
    public class BorrowList
    {
		public int Id { get; set; }
		public int Bid { get; set; }
		public int Cid { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime ReturnDate { get; set; }
	}
}

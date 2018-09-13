using Library.Data.Interfaces;
using Library.Data.Model;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
    public class BorrowListRepository
    {
		protected readonly LibraryDbContext _context;

		public BorrowListRepository(LibraryDbContext context)
		{
			_context = context;
		}

		public IEnumerable<BorrowList> GetAll()
		{
			return _context.BorrowList;
		}
	}
}

using Library.Data.Model;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
	public interface IBookRepository : IRepository<Book>
	{
		new IEnumerable<BookVM> GetAll();
		IEnumerable<Book> GetById(int id);
		IEnumerable<BookVM> Search(string searchFor, bool[] criteria);
	}
}

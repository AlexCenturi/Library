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
		new IEnumerable<Book> GetById(int id);

	}
}

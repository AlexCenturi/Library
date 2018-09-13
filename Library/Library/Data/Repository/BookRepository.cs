using Library.Data.Interfaces;
using Library.Data.Model;
using Library.Models;
using Library.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
	public class BookRepository : Repository<Book>, IBookRepository
	{

		public BookRepository(LibraryDbContext context) : base(context) { }

		public new IEnumerable<BookVM> GetAll()
		{
			return _context.Books.Select(b => new BookVM
			{
				Book = b,
				Available = _context.BorrowList.Any(x => x.Bid == b.Id) ? false : true,
			});
		}

		public new IEnumerable<Book> GetById(int id)
		{
			return _context.Books.Any(b => b.Id == id) ? _context.Books.Where(b => b.Id == id) : null;
		}

		public void Search(string searchFor)
		{

		}

		public void Create(Book book)
		{
			_context.Books.Add(book);
			_context.SaveChanges();
		}
	}
}

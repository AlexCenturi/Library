using Library.Data.Interfaces;
using Library.Data.Model;
using Library.Models;
using Library.ViewModels;
using Microsoft.AspNetCore.Mvc;
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

		public IEnumerable<BookVM> Search(string searchFor, bool[] criteria)
		{
			var searchString = searchFor.ToUpper();

			return _context.Books.Where(b =>
				b.ISBN.Contains(searchString) && criteria[0] ||
			b.Title.ToUpper().Contains(searchString) && criteria[1] ||
				b.Author.ToUpper().Contains(searchString) && criteria[2]
			).Select(b => new BookVM
			{
				Book = b,
				Available = _context.BorrowList.Any(x => x.Bid == b.Id) ? false : true,
			});
		}



		public void Create(Book book)
		{
			_context.Books.Add(book);
			_context.SaveChanges();
		}
	}
}

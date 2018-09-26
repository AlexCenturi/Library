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
	public class BookAndBorrowerRepository : CustomerRepository, IBookAndBorrowerRepository
	{
		public BookAndBorrowerRepository(LibraryDbContext context) : base(context) { }

		public new IQueryable<BookAndBorrowerViewModel> GetAll()
		{
			return from b in _context.Books
				   from mid in _context.BorrowList
				   .Where(c => c.Bid == b.Id).DefaultIfEmpty()

				   from c in _context.Customers
				   .Where(bc => bc.Id == mid.Cid).DefaultIfEmpty()

					   //ToDo 
					   //where (p.Id == 1)
				   select new BookAndBorrowerViewModel
				   {
					   Book = b,
					   Customer = c,
					   StartDate = mid.StartDate != null ? mid.StartDate : new DateTime(),
					   ReturnDate = mid.ReturnDate != null ? mid.ReturnDate : new DateTime(),
				   };
		}

		public IQueryable<BookAndBorrowerViewModel> GetBorrowedBooks()
		{
			return _context.Books
				.Join(_context.BorrowList, b => b.Id, cb => cb.Bid, (b, bc) => new { b, bc })
				.Join(_context.Customers, c => c.bc.Cid, x => x.Id, (bc, x) => new { bc, x })
				.Select(m => new BookAndBorrowerViewModel
				{
					Book = m.bc.b,
					Customer = m.x,
					StartDate = m.bc.bc.StartDate,
					ReturnDate = m.bc.bc.ReturnDate
				});
		}

		public IQueryable<BookAndBorrowerViewModel> Search(string searchFor, bool[] criteria)
		{
			var searchString = searchFor.ToUpper();

			return _context.Books.Where(b =>
				b.ISBN.Contains(searchString) && criteria[0] ||
				b.Title.ToUpper().Contains(searchString) && criteria[1] ||
				b.Author.ToUpper().Contains(searchString) && criteria[2])
				.Join(_context.BorrowList, b => b.Id, cb => cb.Bid, (b, bc) => new
				{
					b,
					bc
				})
				.Join(_context.Customers, c => c.bc.Cid, x => x.Id, (bc, x) => new
				{
					bc,
					x
				})
				.Select(m => new BookAndBorrowerViewModel
				{
					Book = m.bc.b,
					Customer = m.x,
					StartDate = m.bc.bc.StartDate,
					ReturnDate = m.bc.bc.ReturnDate
				});
		}

		// ToDo remove
		public new IEnumerable<Customer> GetById(int id)
		{
			return _context.Customers.Include(b => b.Id == id);
		}
	}
}


using Library.Data.Interfaces;
using Library.Data.Model;
using Library.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
	public class LibraryDbContext : DbContext
	{
		public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
		{

		}

		public LibraryDbContext()
		{

		}

		public virtual DbSet<Book> Books { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<BorrowList> BorrowList { get; set; }
		public virtual DbSet<BookAndBorrowerViewModel> BookAndBorrowerViewModel { get; set; }
	}
}

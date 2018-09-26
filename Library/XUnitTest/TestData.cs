using Library.Data.Interfaces;
using Library.Data.Model;
using Library.Models;
using Library.ViewModels;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XUnitTest
{
	public class TestData
	{
		readonly static List<BorrowList> loanList = new List<BorrowList>
		{
			new BorrowList{Id = 0, Cid = 3, Bid = 2, StartDate = new DateTime(2018,04,30), ReturnDate = new DateTime(2018,05,30)},
			new BorrowList{Id = 1, Cid = 3, Bid = 4, StartDate = new DateTime(2018,08,12), ReturnDate = new DateTime(2018,09,12)},
			new BorrowList{Id = 2, Cid = 4, Bid = 5, StartDate = new DateTime(2018,08,10), ReturnDate = new DateTime(2018,09,10)},
			new BorrowList{Id = 3, Cid = 4, Bid = 6, StartDate = new DateTime(2018,07,15), ReturnDate = new DateTime(2018,08,15)},
			new BorrowList{Id = 4, Cid = 6, Bid = 9, StartDate = new DateTime(2018,07,14), ReturnDate = new DateTime(2018,08,14)},
		};

		public readonly static List<Book> books = new List<Book>
		{
			new Book{Id = 0, ISBN = "9780132350884", Title = "Clean Code", Author = "Robert Martin"},
			new Book{Id = 1, ISBN = "9780137081073", Title = "The Clean Coder", Author = "Robert Martin"},
			new Book{Id = 2, ISBN = "9780804832656", Title = "I Am a Cat", Author = "Soseki Natsume"},
			new Book{Id = 3, ISBN = "9780132350884", Title = "Heavy Weather Sailing", Author = "Peter Bruce"},
			new Book{Id = 4, ISBN = "9789127149946", Title = "Factfulness", Author = "Hans Rosling"},
			new Book{Id = 5, ISBN = "9780132350884", Title = "Liv 3.0", Author = "Max Tegmark"},
			new Book{Id = 6, ISBN = "9789188123930", Title = "Larmrapporten", Author = "Emma Frans"},
			new Book{Id = 7, ISBN = "9780730324218", Title = "The Barefoot Investor", Author = "Scott Pape"},
			new Book{Id = 8, ISBN = "9780132350884", Title = "Moneyball", Author = "Michael Lewis"},
			new Book{Id = 9, ISBN = "9780141031484", Title = "Fooled by Randomness by Nassim", Author = "Nassim Nicholas Taleb"},
		};

		private static DbSet<T> GetQueryableMockDbSet<T>(List<T> sourceList) where T : class
		{
			var queryable = sourceList.AsQueryable();

			var dbSet = new Mock<DbSet<T>>();
			dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
			dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
			dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
			dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());

			return dbSet.Object;
		}

		public static IEnumerable<BookVM> GetAll()
		{
			return null;
		}

		public static DbSet<Book> GetBooks()
		{
			return GetQueryableMockDbSet(books);
		}

		public static DbSet<BorrowList> GetBorrowList()
		{
			return GetQueryableMockDbSet(loanList);
		}

	}
}

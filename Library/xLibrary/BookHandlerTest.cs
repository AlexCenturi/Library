using Library.Data.Repository;
using System.Threading.Tasks;
using Library.Controllers;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Library.Data.Interfaces;
using Library.Data.Model;
using Library.Models;
using Library.ViewModels;
using Library.Handlers;
using Microsoft.EntityFrameworkCore;
using System;

namespace xLibrary
{
	public class BookHandlerTest : IDisposable
	{

		[Fact]
		public void GetExpertGeeks()
		{
			var builder = new DbContextOptionsBuilder<TestDbContext>();
			builder.UseInMemoryDatabase();
			var options = builder.Options;

			using (var context = new TestDbContext(options))
			{
				var books = new List<Book>
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
			}

				using (var context = new TestDbContext(options))
				{
					var repository = new BookRepository(context);
					var expertGeeks = repository.GetAll();
					Assert.Equal(2, expertGeeks.Count());
				}

			}
		}
	}
}

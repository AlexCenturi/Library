using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using Library.Data.Interfaces;
using Library.Data.Model;
using System.Collections.Generic;
using Library.ViewModels;
using Library.Data.Repository;

namespace UnitTest
{
	public class UnitTest1
	{
		readonly IList<Book> books = new List<Book>
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

		Mock<BookRepository> mockBookRepository = new Mock<BookRepository>();


		public TestContext TestContext { get; set; }
		public readonly BookRepository MockBookRepository;


		[TestMethod]
		public void CanReturnAllProducts()

		{

			// Try finding all products

			var testProducts = this.MockBookRepository;



			Assert.IsNotNull(testProducts.GetAll()); // Test if null
			Assert.AreEqual(2, testProducts.GetAll());

		}
	}
	
}

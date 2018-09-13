using System;
using Xunit;
using Moq;

using System.Collections.Generic;
using Library.Data.Model;
using Library.Data.Interfaces;
using Library.ViewModels;
using System.Linq;
using Library.Controllers;
using Library.Data.Repository;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace XUnitTest
{
	public class RepositoryTests : TestData
	{

		public static LibraryDbContext context = new LibraryDbContext
		{
			Books = GetBooks(),
			BorrowList = GetBorrowList(),
		};

		public BookRepository service = new BookRepository(context);

		[Fact]
		public void BookRepositoryGetAllTest_ShouldBe10()
		{
			var data = service.GetAll().ToArray();
			Assert.Equal(10, data.Count());
		}

		[Fact]
		public void BookRepositoryGetByIdTest() 
		{
			var data = service.GetById(1).ToArray()[0];
			Assert.Equal("Robert Martin", data.Author);

			// Index out of range
			var nulldata = service.GetById(10);
			Assert.Null(nulldata);
		}

	
	}
}

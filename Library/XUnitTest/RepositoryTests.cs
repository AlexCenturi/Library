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
			var data = service.GetById(5).ToArray();

			Assert.Single(data);
			Assert.Equal("Max Tegmark", data[0].Author);

			var nulldata = service.GetById(10);
			Assert.Null(nulldata);
		}

		//[Fact]
		//public void BookRepositoryCreateTest()
		//{
		//	var book = new Book { Title = "TestBook", ISBN = "5465456454", Author = "Kalle", Id = 10 };
		//	service.Create(book);
		//}
	}
}

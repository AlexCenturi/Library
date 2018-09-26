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
using Microsoft.AspNetCore.Mvc;

namespace XUnitTest
{
	public class RepositoryTest : TestData
	{

		public new List<Book> books = TestData.books;

		public static LibraryDbContext context = new LibraryDbContext
		{
			Books = GetBooks(),
			BorrowList = GetBorrowList(),
		};

		public BookRepository service = new BookRepository(context);

		[Fact]
		public void BookRepositoryGetAllTest_EqualLength()
		{
			var data = service.GetAll().ToArray();

			Assert.Equal(books.Count, data.Count());
		}

		[Fact]
		public void GetById_ExpectSingleItemEqual()
		{
			for (int i = 0; i < books.Count; i++)
			{
				var id = i;
				var data = service.GetById(id).ToArray();
				Assert.Single(data);
				Assert.Equal(books.ElementAt(id), data[0]);
			}
		}

		[Fact]
		public void GetByIdOutOfRange_ExpectNull() 
		{
			var value = service.GetById(int.MaxValue);
			Assert.Null(value);
			value = service.GetById(int.MinValue);
			Assert.Null(value);
		}

	}
}

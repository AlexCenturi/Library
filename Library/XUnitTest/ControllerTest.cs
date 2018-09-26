using Library.Controllers;
using Library.Data.Interfaces;
using Library.Data.Model;
using Library.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTest
{
	public class ControllerTest
	{


		[Fact]
		public void BookControllerTest()
		{
			var repository = new Mock<IBookRepository>();
			var controller = new BookController(repository.Object);
			controller.Book();
			repository.Verify(repo => repo.GetAll(), Times.Once);

			var result = controller.Book();

			// Assert
			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<IEnumerable<BookVM>>(viewResult.ViewData.Model);
		}
	}

}

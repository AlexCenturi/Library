using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.UnitTests
{
	[TestClass]
	public class BookAndBorrowerRepositoryTests
	{
		[TestMethod]
		public void GetAll_Return_ReturnsBookList()
		{
			//Arrange
			var repo = new BookAndBorrowerRepository();

			// Act
			var result = repo.GetAll();


			// Assert
			Assert.AreEqual(result.length, 10);
	}
	}
}

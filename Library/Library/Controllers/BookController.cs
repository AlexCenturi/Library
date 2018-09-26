using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Library.Handlers;
using Library.Data.Model;
using Library.ViewModels;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    public class BookController : Controller
    {
		private readonly IBookRepository _repository;

		public BookController(IBookRepository repository)
		{
			_repository = repository;
		}


		[HttpGet]
		public IActionResult Book()
		{
			var book = _repository.GetAll().ToArray();
			return View(book);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Book(string searchFor, string[] searchType)
		{
			var criteria = new bool[3];
			criteria[0] = searchType.Contains("isbn") ? true : false;
			criteria[1] = searchType.Contains("title") ? true : false;
			criteria[2] = searchType.Contains("author") ? true : false;

			var book = new BookVM[] { };
			if (ModelState.IsValid)
			{
				book = _repository.Search(searchFor, criteria).ToArray();
			}

			return View(book);
		}
	}
}
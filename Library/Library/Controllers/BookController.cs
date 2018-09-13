using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Library.Handlers;

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



		public IActionResult Book()
		{
			var book = _repository.GetAll().ToArray();
			return View(book);
		}
	}
}


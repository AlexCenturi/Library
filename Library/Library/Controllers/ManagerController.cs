using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data.Interfaces;
using Library.Data.Model;
using Library.Data.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    public class ManagerController : Controller
    {

		private readonly IBookAndBorrowerRepository _repository;

		public ManagerController(IBookAndBorrowerRepository repository)
		{
			_repository = repository;
		}



		public IActionResult Manager()
		{
			var book = _repository.GetAll().ToArray();
			return View(book);
		}

		public IActionResult CreateBook()
		{


			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult CreateBook(Book book)
		{
			if (!ModelState.IsValid)
			{
				//bookVM.Authors = _authorRepository.GetAll();
				//return View(bookVM);
			}

			return View();
		}
	}
}

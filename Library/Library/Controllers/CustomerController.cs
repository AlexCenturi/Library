using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
	public class CustomerController : Controller
	{

		private readonly ICustomerRepository _repository;

		public CustomerController(ICustomerRepository repository)
		{
			_repository = repository;
		}


		// GET: /<controller>/
		public IActionResult CustomerIndex()
		{
			return View();
		}
	}
}

using Library.Data.Interfaces;
using Library.Data.Repository;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Handlers
{
	public class BookHandler
	{

		public IBookRepository _repository;

		public BookHandler(IBookRepository repository)
		{
			_repository = repository;
		}

		public IEnumerable<BookVM> GetAll()
		{
			return _repository.GetAll().ToArray();
		}


	}
}

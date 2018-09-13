using Library.Data.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
	public abstract class Repository<T> : IRepository<T> where T : class
	{

		protected readonly LibraryDbContext _context;
		public Repository(LibraryDbContext context)
		{
			_context = context;
		}

		public IEnumerable<T> GetAll()
		{
			return _context.Set<T>();
		}

		public T GetById(int id)
		{
			return _context.Set<T>().Find(id);
		}

	}
}

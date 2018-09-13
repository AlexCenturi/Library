using Library.Data.Interfaces;
using Library.Data.Model;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Repository
{

	public class CustomerRepository : Repository<Customer>, ICustomerRepository
	{
		public CustomerRepository(LibraryDbContext context) : base(context) { }

		public new IEnumerable<Customer> GetAll()
		{
			return _context.Customers;
		}

		public new IEnumerable<Customer> GetById(int id)
		{
			return _context.Customers.Include(c => c.Id == id);
		}
	}
}

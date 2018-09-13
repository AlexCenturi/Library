using Library.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
	{
		new IEnumerable<Customer> GetAll();
	}
}

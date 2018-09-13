using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
	public interface IGeneric<T> where T : class
	{
		IEnumerable<T> GetAll();
	}
}

using Library.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    interface IBorrowList
    {
		IEnumerable<BorrowList> GetAll();
	}
}

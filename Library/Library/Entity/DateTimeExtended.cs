using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class DateTimeExtended
{
	public DateTime? MyDateTime;
	public int? otherdata;

	public DateTimeExtended() { }

	public DateTimeExtended(DateTimeExtended other)
	{
		this.MyDateTime = other.MyDateTime;
		this.otherdata = other.otherdata;
	}
}

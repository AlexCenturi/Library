using System;
using System.Text.RegularExpressions;

namespace UtilityLibraries
{
	public class IsbnValidator
	{

		/// <summary>
		/// Check if string is a valid ISBN number 10- or 13 digits
		/// (ignores any amount of '-' (hyphen))
		/// </summary>
		/// <param name="isbn"></param>
		/// <returns>bool</returns>
		public bool IsbnDigitCheck(string isbn)
		{
			try
			{
				string ISBN = Regex.Replace(isbn.ToString(), "-", "");

			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Check if int is a valid ISBN number 10- or 13 digits
		/// </summary>
		/// <param name="isbn"></param>
		/// <returns>bool</returns>
		public bool IsbnDigitCheck(int isbn)
		{
			try
			{
				int ISBN = isbn;
				var digits = (int)(Math.Log10(ISBN) + 1);
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}
	}
}

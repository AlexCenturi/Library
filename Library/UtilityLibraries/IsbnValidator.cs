using System;
using System.Text.RegularExpressions;

namespace UtilityLibraries
{

	/// <summary>
	/// Check if an int or string is a valid ISBN-number
	/// </summary>
	public class IsbnValidator
	{

		//ToDo Add exception for books with an ISBN equal with another book i.e. "Cancelled ISBN"

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
				int isbnInt = Convert.ToInt32(ISBN);
				return IsbnDigitCheck(isbnInt);
			}
			catch (Exception)
			{
				return false;
			}
		}

		public void ConvertIsbn10ToIsbn13(int isbn10)
		{
			long isbn13 = isbn10 + 9780000000000;
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
				return IsbnDigitCheck(ISBN);
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool Isbn(int isbn)
		{
			int ISBN = isbn;
			var digits = (int)(Math.Log10(ISBN) + 1);

			if (digits == 10)
			{
				return true; //toDo
			}
			else if (digits == 13)
			{
				return true; //ToDo
			}
			else
				return false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="isbnArr"></param>
		/// <returns></returns>
		public bool Isbn10Check(int[] isbnArr)
		{
			var sum = 0;
			for (int i = 0; i < isbnArr.Length - 1; i++)
			{
				sum += isbnArr[i] * (10 - i);
			}
			sum += isbnArr[9];

			return sum % 11 == 0;
		}

		public bool Isbn13Check(int[] isbnArr)
		{
			var sum = 0;
			for (int i = 0; i < isbnArr.Length - 1; i++)
			{
				sum += isbnArr[i] * (i % 2 == 0 ? 1 : 3);
			}

			return sum % 10 == 0;
		}

		public static int[] ToIntArray(int n, int digits)
		{
			int[] intArr = new int[digits];
			for (int i = 0; i < digits; i++)
			{
				intArr[digits - i - 1] = n % 10;
				n /= 10;
			}
			return intArr;
		}

	}
}

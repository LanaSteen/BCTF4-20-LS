using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lecture12
{
	internal class Money
	{
		public int Val;
		public string Currency;

		public override string? ToString()
		{
			return $"{Val} {Currency}";
		}


		//+ opperator
		public static Money operator +(Money m1, Money m2)
		{

			if(m1.Currency != m2.Currency)
			{
				Console.WriteLine("Different currencies");
				return null;
			}
			else
			{
				return new Money
				{
					Val = m1.Val + m2.Val,
					Currency = m1.Currency
				};

			}
			
		}

		public static Money operator -(Money m1, Money m2)
		{

			if (m1.Currency != m2.Currency)
			{
				Console.WriteLine("Different currencies");
				return null;
			}
			else
			{
				return new Money
				{
					Val = m1.Val - m2.Val,
					Currency = m1.Currency
				};

			}

		}
		public static Money operator *(Money m1, Money m2)
		{

			if (m1.Currency != m2.Currency)
			{
				Console.WriteLine("Different currencies");
				return null;
			}
			else
			{
				return new Money
				{
					Val = m1.Val * m2.Val,
					Currency = m1.Currency
				};

			}

		}

		public static Money operator /(Money m1, Money m2)
		{

			if (m1.Currency != m2.Currency)
			{
				Console.WriteLine("Different currencies");
				return null;
			}
			else
			{
				return new Money
				{
					Val = m1.Val / m2.Val,
					Currency = m1.Currency
				};

			}

		}

		public static Money operator %(Money m1, Money m2)
		{

			if (m1.Currency != m2.Currency)
			{
				Console.WriteLine("Different currencies");
				return null;
			}
			else
			{
				return new Money
				{
					Val = m1.Val % m2.Val,
					Currency = m1.Currency
				};

			}

		}



		public static Money operator ++(Money m1)
		{

			return new Money
			{
				Val = m1.Val += 1,
				Currency = m1.Currency
			};

		}
		public static Money operator --(Money m1)
		{

			return new Money
			{
				Val = m1.Val -= 1,
				Currency = m1.Currency
			};

		}


		public static bool operator ==(Money m1, Money m2)
		{

			return m1.Val == m2.Val && m1.Currency == m2.Currency;

		}
		public static bool operator !=(Money m1, Money m2)
		{

			return m1.Val != m2.Val || m1.Currency != m2.Currency;

		}


		public static bool operator >(Money m1, Money m2)
		{

			return m1.Val > m2.Val && m1.Currency == m2.Currency;

		}
		public static bool operator <(Money m1, Money m2)
		{

			return m1.Val < m2.Val && m1.Currency == m2.Currency;

		}


		public static bool operator <=(Money m1, Money m2)
		{

			return m1.Val <= m2.Val && m1.Currency == m2.Currency;

		}
		public static bool operator >=(Money m1, Money m2)
		{

			return m1.Val <= m2.Val && m1.Currency == m2.Currency;

		}

	}
}

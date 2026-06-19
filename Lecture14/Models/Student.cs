using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lecture14
{
	internal class Student
	{

		public Remark<int> Grade {  get; set;}
		public Remark<string> Comment { get; set; }
		public Remark<bool> Passed { get; set; }


		//public Comment Comment { get; set; }
		//public PassedExame PassedExame { get; set; }

		//public void Print<T>(T param)
		//{
		//	Console.WriteLine($"Hello your {typeof(T).Name} is {param}");
		//}

	}

	//grade , comment, passed

	public class Remark<T>  // where T : struct
	{
		public RemarkType Type { get; set; }
		public T Value { get; set; }

		public override string ToString()
		{
			return $"{Type} {Value}";
		}

		public void Print()
		{
			Console.WriteLine($"Hello your {Type} is {Value}");
		}


	}

	//public class Remark<T>
	//{
	//	public RemarkType Type { get; set; }
	//	public T Value { get; set; }

	//	public override string ToString()
	//	{
	//		return $"{Type} {Value}";
	//	}

	//	public void Print()
	//	{
	//		Console.WriteLine($"Hello your {Type} is {Value}");
	//	}


	//}


	public enum RemarkType
	{
		Grade,
		Comment,
		Passed
	}



	//public class Grade
	//{
	//	public int Value { get; set; }

	//	public override string ToString()
	//	{
	//		return $"{Value}";
	//	}


	//	public void Print()
	//	{
	//		Console.WriteLine($"Hello your grade is {Value}");
	//	}
	//}
	//public class Comment
	//{
	//	public string Value { get; set; }
	//	public override string ToString()
	//	{
	//		return $"{Value}";
	//	}
	//	public void Print()
	//	{
	//		Console.WriteLine($"Hello your Comment is {Value}");
	//	}
	//}
	//public class PassedExame
	//{
	//	public bool Value { get; set; }
	//	public override string ToString()
	//	{
	//		return $"{Value}";
	//	}
	//	public void Print()
	//	{
	//		Console.WriteLine($"Hello your PassedExame is {Value}");
	//	}
	//}


}

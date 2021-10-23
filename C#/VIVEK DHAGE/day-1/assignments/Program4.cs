using System;

namespace weekday
{

	enum weekday { 
		sunday ,
		monday,
		tuesday,
		wednesday,
		thirsday,
		friday,
		saturday
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");



			int num = 0;
			Console.WriteLine("enter weekday");
			num = Console.Read();


			if (num <6 )
			{
				Console.WriteLine("you've entered wrong day");
			     if (num == 0)
				{
					Console.WriteLine("sunday");
				}
				else if (num == 1)
				{
					Console.WriteLine("monday");
				}
				else if (num == 2)
				{
					Console.WriteLine("tuesday");
				}
				else if (num == 3)
				{
					Console.WriteLine("wednesday");
				}
				else if (num == 4)
				{
					Console.WriteLine("thirsday");
				}
				else if (num == 5)
				{
					Console.WriteLine("friday");
				}
				else if (num == 6)
				{
					Console.WriteLine("saturday");
				}
			}
			
			else { 
			}
		}
	}
}

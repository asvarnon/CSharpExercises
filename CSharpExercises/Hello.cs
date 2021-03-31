using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class Hello
	{
		public void DoHello()
		{
			Console.WriteLine("Hello from a class in a namespace!");
		}
	}
}

class Hello
{
	public void DoHello()
	{
		Console.WriteLine("Hello from a class outside a namespace!");
	}
}

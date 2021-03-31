using System;

//removed namespace here to prove it isnt needed

class Program
{
	//ignore static for right now... just easiest way to keep code small

	static Hello hello = new Hello();
	static ConsoleApp1.Hello hello1 = new ConsoleApp1.Hello();

	//Will not compile
	//Hello hello2 = new ConsoleApp1.Hello();
	//ConsoleApp1.Hello hello3 = new Hello();
	
	
	static void Main(string[] args)
	{
		hello.DoHello();
		hello1.DoHello();
	}
}


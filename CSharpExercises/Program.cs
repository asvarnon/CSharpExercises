using System;
using CSharpExercises;

//removed namespace here to prove it isnt needed

class Program
{
	//ignore static for right now... just easiest way to keep code small

	private static Hello hello = new Hello();
	private static ConsoleApp1.Hello hello1 = new ConsoleApp1.Hello();
    private static ConsoleApp2.Hello hello2 = new ConsoleApp2.Hello();

	//Will not compile
	//Hello hello2 = new ConsoleApp1.Hello();
	//ConsoleApp1.Hello hello3 = new Hello();
	
	
	static void Main(string[] args)
	{
		hello.DoHello();
		hello1.DoHello();
		hello2.DoHello();

        Dog dog1 = new Dog{name = "Jasper", age = 6, breed = "Lab"};
        dog1.name += "!";
    }
}


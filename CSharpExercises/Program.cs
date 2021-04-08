using System;
using System.Globalization;
using CSharpExercises;
using CSharpExercises.Math;

//removed namespace here to prove it isnt needed

public class Program
{
	//ignore static for right now... just easiest way to keep code small

	private static Hello hello = new Hello();
	private static ConsoleApp1.Hello hello1 = new ConsoleApp1.Hello();
    private static ConsoleApp2.Hello hello2 = new ConsoleApp2.Hello();

	//Will not compile
	//Hello hello2 = new ConsoleApp1.Hello();
	//ConsoleApp1.Hello hello3 = new Hello();
    
	
	public static void Main(string[] args)
	{
		//hello.DoHello();
		//hello1.DoHello();
		//hello2.DoHello();

		//Dog dog1 = new Dog{name = "Jasper", age = 6, breed = "Lab"};

        //try
        //{
        //string number = "1234";
        //    //int.Parse(number);
        //    //byte b = Convert.ToByte(number);
        //    //Console.WriteLine(b);

        //    string str = "true";
        //    bool b = Convert.ToBoolean(str);
        //    Console.WriteLine(b);
        //}
        //catch (Exception)
        //{
        //    Console.WriteLine("The number could not be converted");
            
        //}

        //Person john = new Person();
        //john.firstName = "John";
        //john.lastName = "Johnson";
        //john.introduce();

        Calculator calculator = new Calculator();
        int result = calculator.add(1, 2);
        int subtractResult = calculator.subtract(3, 2);
        Console.WriteLine($"Result is {result}", result);
        Console.WriteLine($"result of subtraction is {subtractResult}", subtractResult);
    }
}


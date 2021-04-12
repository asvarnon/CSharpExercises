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

        //Calculator calculator = new Calculator();
        //int result = calculator.add(1, 2);
        //int subtractResult = calculator.subtract(3, 2);
        //Console.WriteLine($"Result is {result}", result);
        //Console.WriteLine($"result of subtraction is {subtractResult}", subtractResult);

        //int[] numbers = new int[3];
        //numbers[0] = 1;

        //Console.WriteLine(numbers[0]);
        //Console.WriteLine(numbers[1]);
        //Console.WriteLine(numbers[2]);

        //bool[] flags = new bool[3];
        //flags[0] = true;

        //Console.WriteLine(flags[0]);
        //Console.WriteLine(flags[1]);
        //Console.WriteLine(flags[2]);

        //string[] names = new string[3] { "Jack", "John", "Mary" };
        //Console.WriteLine(names[1]);

        //string list = string.Join(",", numbers);
        //Console.WriteLine(list);

        //string name = names[1];
        //char firstChar = name[0];
        //Console.WriteLine(firstChar);
        //Strings are immutable

        //string path = @"c:\projects\project1\folder1";

//        int number;
//        string firstName = "Austin";
//        string lastName = "Varnon";
//        string fullName = string.Format("{0} {1}", firstName, lastName);

//        string text = @"Hi John, 
//Look into the following paths:
//C:folder1\folder2
//C:folder3\folder4";
//        Console.WriteLine(text);


        var enumMethod = ShippingMethod.Express;
        Console.WriteLine((int)enumMethod);

        var enumMethodId = 3;
        Console.WriteLine((ShippingMethod)enumMethodId);

        Console.WriteLine(enumMethod.ToString());

        string methodName = "Express";
        var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

    }
}


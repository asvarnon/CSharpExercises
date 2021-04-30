using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
    public static List<double> randomNumberList(double max)
    {
        List<double> numbers = new List<double>();
        for (int i = 0; i < max; i++)
        {
            numbers.Add(i + 1);
        }
        return numbers;
    }

    public static char[] PasswordGenerator(int passwordLength)
    {
        var random = new Random();
        char[] buffer = new char[passwordLength];

        for (var i = 0; i < passwordLength; i++)
        {
            //can produce random string using numbers that represent letters
            buffer[i] = (char)('a' + random.Next(0, 26));
        }

        return buffer;
    }

	public static void Main(string[] args)
	{
        //-------------------------------------------------------------Namespace Example----------------------------------------------------------------------
        //hello.DoHello();
        //hello1.DoHello();
        //hello2.DoHello();

        //-------------------------------------------------------------Try/catch/OOP Example----------------------------------------------------------------------

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

        //-------------------------------------------------------------Arrays Example----------------------------------------------------------------------

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

        //-------------------------------------------------------------Strings Example----------------------------------------------------------------------

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

        //-------------------------------------------------------------Enum Example----------------------------------------------------------------------

        //var enumMethod = ShippingMethod.Express;
        //Console.WriteLine((int)enumMethod);

        //var enumMethodId = 3;
        //Console.WriteLine((ShippingMethod)enumMethodId);

        //Console.WriteLine(enumMethod.ToString());

        //string methodName = "Express";
        //var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

        //-------------------------------------------------------------Reference and Value types Example----------------------------------------------------------------------

        //int a = 10;
        //int b = a;
        //b++;
        //Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

        //int[] array1 = new int[3] {1, 2, 3};
        //int[] array2 = array1;
        //array2[0] = 0;
        //Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        //Console.WriteLine(string.Format("array1[2]: {0}, array2[0]: {1}", array1[2], array2[2]));

        //-------------------------------------------------------------inline conditional  Example----------------------------------------------------------------------

        //bool isGoldCustomer = true;
        //double price = (!isGoldCustomer) ? 19.95 : 29.95;
        //Console.WriteLine(price);


        //Enum season = Season.Winter;

        //switch (season)
        //{
        //    case Season.Autumn:
        //    case Season.Summer:
        //        Console.WriteLine("Fall and Summer Sales Event!");
        //        break;
        //    default:
        //        Console.WriteLine("Default message here.");
        //        break;
        //}


        //-------------------------------------------------------------Valid/Invalid number exercise----------------------------------------------------------------------

        //Console.WriteLine("Enter a number between 1 & 10");
        //String userInput = Console.ReadLine();
        //int convertedInput = int.Parse(userInput);

        //if (convertedInput >= 1 && convertedInput <= 10)
        //{
        //    Console.WriteLine("Valid");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid");
        //}

        //-------------------------------------------------------------iteration examples----------------------------------------------------------------------

        //Console.WriteLine("Enter a number for max value of range.");
        //String userInput = Console.ReadLine();

        //foreach (var number in randomNumberList(double.Parse(userInput)))
        //{
        //    Console.WriteLine(number);

        //const int passwordLength = 26;
        //var random = new Random();
        //char[] buffer = new char[passwordLength];


        //for (var i = 0; i < passwordLength; i++)
        //{
        //    //can produce random string using numbers that represent letters
        //   buffer[i] = (char)('a' + random.Next(0, 26));
        //}

        //String password = new string(PasswordGenerator(26));
        //String password2 = new string(PasswordGenerator(52));

        //Console.WriteLine(password);
        //Console.WriteLine(password2);


        //-------------------------------------------------------------Multi Dimensional array examples----------------------------------------------------------------------

        ////can use object initialization to make array (reminder)
        //int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};

        ////length
        //Console.WriteLine($"Length: {numbers.Length}", numbers.Length);

        //// IndexOf()
        //var index = Array.IndexOf(numbers, 3);
        //Console.WriteLine($"index of 9 is: {index}", index);

        //// Clear()
        ////resets int to 0, booleans to False, and strings to Null.
        //Array.Clear(numbers,1,2);
        //Console.WriteLine("Effect of Clear()");
        //foreach (var num in numbers)
        //{
        //    Console.WriteLine(num);   
        //}

        //Console.WriteLine("Effect of Copy()");
        ////Copy()
        //int[] anotherArray = new int[3];
        //Array.Copy(numbers, anotherArray,3);
        //foreach (var num in anotherArray)
        //{
        //    Console.WriteLine(num);
        //}

        ////Sort()
        //Array.Sort(numbers);
        //Console.WriteLine("Effect of Sort()");
        //foreach (var num in numbers)
        //{
        //    Console.WriteLine(num);
        //}

        ////Reverse()
        //Array.Reverse(numbers);
        //Console.WriteLine("Effect of Reverse()");
        //foreach (var num in numbers)
        //{
        //    Console.WriteLine(num);
        //}


        ////---------RECTANGULAR ARRAYS
        ////2D array    [number of elements, number of elements within each parent element]
        //var matrix = new int[3, 3]
        //{
        //    {1,2,3},
        //    {4,5,6},
        //    {7,8,9}
        //};

        //// REMEMBER: count starts at 0. 
        //var element = matrix[1, 2];
        ////Console.WriteLine(element);

        ////--------JAGGED ARRAYS
        //var array = new int[3][];

        //array[0] = new int[4];
        //array[1] = new int[5];
        //array[2] = new int[3];

        ////how to assign each element
        //array[0][0] = 1;
        //array[0][1] = 2;


        //-------------------------------------------------------------Lists examples----------------------------------------------------------------------

        //var numbers = new List<int>() {1,2,3,4};
        //numbers.Add(1);
        //numbers.AddRange(new int[3] {5,6,7});

        //foreach (var num in numbers)
        //{
        //    Console.WriteLine(num);
        //}
        //var index = numbers.IndexOf(1);
        //Console.WriteLine($"index of 1 is: {index}", index);
        //Console.WriteLine($"Last index of 1 is: {numbers.LastIndexOf(1)}");
        //Console.WriteLine($"Count: {numbers.Count}");

        ////CANNOT modify a collection within a ForEach Loop. 
        //Console.WriteLine("Effect of Remove");
        //for (var i = 0; i < numbers.Count; i++)
        //{
        //    if (numbers[i] == 1)
        //    {
        //        numbers.Remove(numbers[i]);
        //    }
        //}
        //foreach (var num in numbers)
        //{
        //    Console.WriteLine(num);
        //}

        //numbers.Clear();
        //Console.WriteLine($"Count: {numbers.Count}");

        //-------------------------------------------------------------DateTime examples----------------------------------------------------------------------
        //var dateTime = new DateTime(2015, 1, 1);
        //var now = DateTime.Now;
        //var today = DateTime.Today;
        //Console.WriteLine($"It is Currently {now.Hour - 12}:{now.Minute}");

        //var tomorrow = now.AddDays(1);
        //var yesterday = now.AddDays(-1);

        //Console.WriteLine($"LONG date string: {now.ToLongDateString()}");
        //Console.WriteLine($"SHORT date string: {now.ToShortDateString()}");
        //Console.WriteLine($"LONG time string: {now.ToLongTimeString()}");
        //Console.WriteLine($"SHORT time string: {now.ToShortTimeString()}");
        //Console.WriteLine($"date AND time: {now.ToString("D")}");
        //Console.WriteLine($"date AND time: {now:D}");   //same as above

        //-------------------------------------------------------------Timespan examples----------------------------------------------------------------------

        ////creating
        //var timespan = new TimeSpan(1,2,3);
        //var timespan1 = TimeSpan.FromHours(1);

        //var start = DateTime.Now;
        //var end = DateTime.Now.AddMinutes(2);
        //var duration = end - start;
        //Console.WriteLine($"Duration is: {duration}");

        ////properties
        //Console.WriteLine($"Minutes: {timespan.Minutes}");
        //Console.WriteLine($"Total Minutes: {timespan.TotalMinutes}");

        //// Add (adds 8 minutes to timespan)
        //Console.WriteLine($"Add Example: {timespan.Add(TimeSpan.FromMinutes(8))}");

        ////Subtract
        //Console.WriteLine($"Subtract Example: {timespan.Subtract(TimeSpan.FromMinutes(2))}");

        ////Timespan to String conversion
        //var convertedTimeSpan = timespan.ToString();
        //Console.WriteLine($"toString {convertedTimeSpan}");

        ////String to Timespan
        //Console.WriteLine($"Parse: {TimeSpan.Parse("01:02:03")}");
        //Console.WriteLine($"Parse: {TimeSpan.Parse(convertedTimeSpan)}");

        //-------------------------------------------------------------Indepth String examples----------------------------------------------------------------------


        String str = "1234";
        int i = Convert.ToInt32(str);
        Console.WriteLine(i.GetType());
        String convertedStr = i.ToString("C"); //currency with 2 decimals
        String convertedStr1 = i.ToString("C0"); //currency with no decimals

        var fullName = "Austin Varnon";
        var index = fullName.IndexOf(" ");
        var firstName = fullName.Substring(0, index);
        var lastName = fullName.Substring(index + 1);

        var names = fullName.Split();

        //Console.WriteLine(fullName);
        //Console.WriteLine(index);
        //Console.WriteLine(firstName);
        //Console.WriteLine(lastName);

        //Console.WriteLine($"Split String array First Name: {names[0]}");
        //Console.WriteLine($"Split String array Last Name: {names[1]}");

        var sentence = "This is a really really really really really really really really long text";
        var summary = StringUtility.SummerizeText(sentence,25);
        // Console.WriteLine(summary);

        //------String Builder
        var builder = new StringBuilder();
        //can chain like this below rather than examples with replace, remove, etc.
        builder
            .Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10);

        builder.Replace('-', '+');
        builder.Remove(0, 5);
        builder.Insert(2,new string('-', 10));

        Console.WriteLine(builder);


    }


}





using System;

public class Person
{
    public string firstName;
    public string lastName;

    public void introduce()
    {
        Console.WriteLine($"My name is {firstName} {lastName}.", firstName, lastName);
    }
}
using System;

public class Person
{
    public string firstName;
    public string lastName;

    public void introduce(string receiver)
    {
        Console.WriteLine($"Hello {receiver}, My name is {firstName} {lastName}.");
    }

    public static Person Parse(string firstName, string lastName)
    {
        var person = new Person();
        person.firstName = firstName;
        person.lastName = lastName;

        return person;
    }
}
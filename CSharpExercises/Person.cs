using System;

public class Person
{
    private string firstName;
    private string lastName;

    public Person()
    {
    }
    public Person(string firstName)
    {
        this.firstName = firstName;
    }
    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

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
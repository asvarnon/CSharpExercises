using System;
using System.Collections.Generic;

public class Person
{
    private string firstName;
    private string lastName;
    private List<Order> orders;

    public Person()
    {
        orders = new List<Order>();
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
    public Person(string firstName, string lastName, List<Order> orders)
        :this()
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.orders = orders;
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
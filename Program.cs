using System.Collections.Generic;

namespace ClassroomProj;

class Program
{
    static void Main(string[] args)
    {
        // create user list
        List<string> names = new List<string>();

        // adding users to the creation
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");

        string firstPerson = names[0];
        Person firstUser = new Student(232912, 90, "232912@class.org", firstPerson, "landon", 1234561234);
        Console.WriteLine(firstUser);
    }
}
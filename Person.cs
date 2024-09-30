using System.ComponentModel;

abstract class Person
{
    // declare variables
    public string EmailAddress { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int PhoneNumber { get; set; }
    public int id { get; set; }


    // default constructor
    public Person()
    {
        EmailAddress = "";
        FirstName = "";
        LastName = "";
        PhoneNumber = 0;

    }

    // user constructor
    public Person(string emailAddress, string firstName, string lastName, int phoneNumber)
    {
        EmailAddress = emailAddress;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
    }

    // base override
    public override string ToString()
    {
        return $"Email Address: {EmailAddress}, First Name: {FirstName}, Last Name: {LastName}, Phone Number {PhoneNumber}";
    }
}
 
// student class
class Student : Person
{
    // declare variables
    public int StudentID { get; set; }
    public int StudentAverage { get; set; }

    // default constructor
    public Student () : base()
    {
        StudentID = 0;
        StudentAverage = 0;
    }

    // user constructor
    public Student (int studentID, int studentAverage, string emailAddress, string firstName, string lastName, int phoneNumber) : base (emailAddress, firstName, lastName, phoneNumber)
    {
        StudentID = studentID;
        StudentAverage = studentAverage;
    }

    // base override
    public override string ToString()
    {
        return $"{base.ToString()}, Student ID: {StudentID}, Student Average: {StudentAverage}";
    }
}

// teacher class
class Teacher : Person
{
    // declare variables
    public string TeacherClass { get; set; }
    public int Salary { get; set; }

    // deafault constructor
    public Teacher () : base ()
    {
        TeacherClass = "";
        Salary = 0;
    }

    // user constructor
    public Teacher (string teacherClass, int salary, string emailAddress, string firstName, string lastName, int phoneNumber) : base (emailAddress, firstName, lastName, phoneNumber)
    {
        TeacherClass = teacherClass;
        Salary = salary;
    }

    // base override
    public override string ToString()
    {
        return $"{base.ToString()}, Class: {TeacherClass}, Salary: {Salary}";
    }
}
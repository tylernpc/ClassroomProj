abstract class Person
{
    // declare variables
    public string EmailAddress { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int PhoneNumber { get; set; }


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
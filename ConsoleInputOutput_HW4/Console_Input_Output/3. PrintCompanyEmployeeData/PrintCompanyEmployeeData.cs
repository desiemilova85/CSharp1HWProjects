using System;

class PrintCompanyEmployeeData
{
    static void Main()
    {
        Console.Write("Please enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Plaease enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Please enter company phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Please enter company fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Please enter company web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Please enter manager's first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Please enter manager's last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Please enter manager's age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Please enter manager's mobile number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine("Company name: {0}", companyName);
        Console.WriteLine("Company Address: {0}", companyAddress);
        Console.WriteLine("Company Phone number: {0}", companyPhoneNumber);
        Console.WriteLine("Company Fax number: {0}", companyFaxNumber);
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager's name: {0} {1},\nManager's age: {2} years,\nPrivate phone number: {3}", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}

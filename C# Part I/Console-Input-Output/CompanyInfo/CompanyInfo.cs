//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints them on the console.
using System;

class CompanyInfo
{
    static void Main()
    {
        string name, address, webiste, firstname, lastname, faxNumber, fullName;
        short age;
        int managerPhoneNumber, companyPhoneNumber ;


        Console.WriteLine("Enter company information: ");
        Console.Write("Company name: ");
        name = Console.ReadLine();
        Console.Write("Company address: ");
        address = Console.ReadLine();
        Console.Write("Company phone number: ");
        companyPhoneNumber = Int32.Parse(Console.ReadLine());
        Console.Write("Company website: ");
        webiste = Console.ReadLine();
        Console.Write("Company faxNumber number: ");
        faxNumber = Console.ReadLine();
        Console.Write("Manager firstname: ");
        firstname = Console.ReadLine();
        Console.Write("Manager lastname: ");
        lastname = Console.ReadLine();
        Console.Write("Manager phonenumber: ");
        managerPhoneNumber = Int32.Parse(Console.ReadLine());
        Console.Write("Manager age: ");
        age = short.Parse(Console.ReadLine());
        fullName = firstname + lastname;

        Console.WriteLine("{0} on location \'{1}\'\nFor more information visist our website {2} , send as a fax on {3} or contact us on our telephone number: {4}",name,address,webiste,faxNumber,companyPhoneNumber);
        Console.WriteLine("Our manager is {0} {1} years old. You can call him on {2}", fullName, age, managerPhoneNumber);



    }
}



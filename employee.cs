using System;

class Employee{
  
    private string firstname;
    private string lastname;

    private string id;
    private int age;
    private string address;

    private string phonenumber;
    private string title;
    private double yearlysalary;
    private string employmentstatus;

    public Employee(){
      firstname = "Unknown";
      lastname = "Unknown";
      id = "Unknown";
      age =0;
      employmentstatus = "active";
    }

    public Employee(string firstName, string lastName, string empid, int empage){
      firstname = firstName;
      lastname = lastName;
      id = empid;
      age = empage;
      employmentstatus = "active";
    }

public void Intro(){
Console.WriteLine("Employee first name is " + firstname);
Console.WriteLine("Employee last name is " + lastname);
Console.WriteLine("Employee Id is " + id);
Console.WriteLine("Employee age is " + age);
Console.WriteLine("Employee status is " + employmentstatus);
}
}



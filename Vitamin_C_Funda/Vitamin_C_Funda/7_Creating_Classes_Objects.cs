using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Vitamin_C_Funda
{
    public class _7_Creating_Classes_Objects // this is class definition - "public" make the class accessible from everywhere
    // body of a class - inside the curely braces 
    // inside the body we have fields, fields are class- level variables that will hold data
    // inside the body we also ave methods - that contains functionality that works with our data
    // data will typical live in properties which grab the fields
    // also class can contain events 

            // Creating a class
        /*
        class is Blueprint of an object. class represent a concept
        class is a template for creating objects
        class is a collection of methods and variables
        We will instantiate an jobject of the class

        For example, consider a class called Car. 
        The Car class might have properties like color, model, and year, and methods like startEngine() and accelerate(). 
        When you instantiate the Car class, you create a specific object, like a ToyotaCamry object, which has its own values for color,
        model, and year, and can use the startEngine() and  accelerate() methods.
        
        */
        // Creating a  employee class 
        // identity : Name
        // attributes : Age, Wage 
        // Behaviors: Get paid, Perform work
    {
    
        public string? firstname;
        public string? lastname;
        public string? email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime birthDay;

        // add a constant for a clean code
        const int minimalHoursWorkedUnit = 1;

        // method 1 
        public void Performwork() // this is method
        {
            //numberOfHoursWorked++;
            //System.Console.WriteLine($"{firstname} {lastname} has worked for {numberOfHoursWorked} Hour(s)!");
            //Performwork(minimalHoursWorkedUnit);

        }
        // method 2 - method overloading
        public void Performwork(int numberOfHours) 

        {
            // pass in the number of hourss
            // numberOfHoursWorked += numberOfHours;
            // System.Console.WriteLine($"{firstname} {lastname} has worked for {numberOfHoursWorked} Hour(s)!");

        }

        // method 3 - recieve a wage
        // public double RevieveWage(bool resetHours = true)
        // {
        //     wage = numberOfHoursWorked * hourlyRate;
        //     System.Console.WriteLine($"{firstname} {lastname} has recieved a wage of {wage} for {numberOfHoursWorked} hour(s).");

        //     if (resetHours)
        //     numberOfHoursWorked = 0;
            
        //     return wage;
        // }
 //----------------
        // Adding a Constructor with parameters
        /*
        Employee employee = new Employee("Bethany", 35);
        Employee is varibale type
        employee is variable name
        Employee is class, ("Bethany", 35) is a Constructor arguments
        */

        /*
        Employee employee = new Employee (); // instantiating the object
        employee.PerformWork(); // Invoking a method
        employee.firstName = "Bethany"; // Changing a a field
        int wage = employee.receiveWage(); // Returining a value from a method  
*/
/*
// Adding a Constructor with parameters
        internal class Employee
        {
        public string? firstname;
        public string? lastname;
        public string? email;

        // public int numberOfHoursWorked;
        // public double wage;
        public double hourlyRate;
        public DateTime birthDay;

        // add a constant for a clean code
        const int minimalHoursWorkedUnit = 1;
            
                public Employee(string first, string last, string em, DateTime bd, double rate)
            {
                firstname = first;
                lastname = last;
                email = em;
                birthDay = bd;
                hourlyRate = rate;
            }
        
            
            
            }
    
        
        
*/


    }
}

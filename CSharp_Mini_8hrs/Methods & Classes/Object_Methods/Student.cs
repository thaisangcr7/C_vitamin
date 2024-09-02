using System;

namespace Object_Methods;

public class Student
{
    public string name; 
    public string major; 
    public double gpa;

// constructor     
public Student(string aName, string aMajor, double aGpa)
{
    name = aName;
    major = aMajor;
    gpa = aGpa;
}

// Method
// whether or not the student has an honor
public bool HasHonors()
{
    if (gpa >= 3.5)
    {
        return true;
    }
    return false;
}
 
}

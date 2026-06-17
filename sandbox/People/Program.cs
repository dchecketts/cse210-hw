using System;
using People;

class Program
{
    static void Main(string[] args)
    {
        Person myPerson = new Person("Daniel", "Checketts", 21, 165);
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice = new Police("Jimmy", "Stewart", 43, 197, "Gun");
        Console.WriteLine(myPolice.GetPoliceInformation());
        
        Doctor myDoctor = new Doctor("Samuel", "Jones", 21, 165, "MD");
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}
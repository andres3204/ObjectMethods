using System;

namespace ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student1 = new Student("Andres", "Computer Science", 3.6);
            Student student2 = new Student("Luis", "Business", 3.5);
            Student student3 = new Student("Sofia", "Art Design", 2.9);

            
            Console.WriteLine(student1.Name + "," + " who studies " + student1.Major + "," + " has a GPA of " + student1.GPA +"," + " therefore he " + student1.HasHonors());
            Console.WriteLine(student2.Name + "," + " who studies " + student2.Major + "," + " has a GPA of " + student2.GPA +"," + " therefore he " + student2.HasHonors());
            Console.WriteLine(student3.Name + "," + " who studies " + student3.Major + "," + " has a GPA of " + student3.GPA +"," + " therefore he " + student3.HasHonors());

            Console.ReadLine();
        }
    }
}

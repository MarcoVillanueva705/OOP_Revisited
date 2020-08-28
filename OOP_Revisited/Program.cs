using System;
using System.Collections.Generic;

namespace LearningCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate a new Student Class object
            var students = new List <Student>();
            //to access the Name property, specify the object variable name
            //use the dot operator after specifying the object variable name
            //to access the Name property
            

            //boolean that means in this while loop, all code will
            //continue to happen in it until reaching a false condition
            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                Console.Write("Student Name...");
                newStudent.Name = (Console.ReadLine());

                Console.Write("Student Grade...");
                newStudent.Grade = (int.Parse(Console.ReadLine()));

                Console.Write("Student Birthday...");
                newStudent.Birthday = (Console.ReadLine());

                Console.Write("Student Address...");
                newStudent.Address = (Console.ReadLine());

                //data type for phone# (and grade) in Class property is int
                Console.Write("Student Phone...");
                newStudent.Phone = (int.Parse(Console.ReadLine()));

                //add a newStudent to the List <Student> collection
                students.Add(newStudent);

                Console.Write("Add another student? y/n");

                if (Console.ReadLine() != "y")
                {
                    //break out of while loop because we flip the
                    //boolean and adding arg to false once "y" typed
                    adding = false;
                }

                foreach (var student in students)
                {
                    //Name is obj arg 0 as string(student.Name), and Grade is obj arg 1 as int(student.Grade)
                    //parameters arr[i] lists the data from the loop
                    Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                }
            }
        }
        //class acts like a blueprint for making an object; use instead of separate lists
        //to scale down code
    }
        class Student
        {
            //public keyword makes properties useable by another class
            //in this instance, the Program class can use these props
            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            public int Phone;
        //var keyword outside of class allows C# to pick the correct type (local var)
        //we can't use var in our class; we are defining a blueprint with our class Student
        //future objects, we will want to make or instantiate i.e. var student = new Student();
        //blueprints need to have every detail defined; must specify what type each property will be
        //so we can guarantee objects of that class match the blueprint exactly
        //this is a C# concept called 'type safety'
        //this enforces the type of data we use in specific variable types
        }
}

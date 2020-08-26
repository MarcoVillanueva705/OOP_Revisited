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
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.Write("Add another student? y/n");

                if (Console.ReadLine() != "y")
                {
                    //break out of while loop because we flip the
                    //boolean and adding arg to false once "y" typed
                    adding = false;
                }

                for (int i = 0; i < studentNames.Count; i++)
                {
                    //Name is obj arg 0 as string(studentNames), and Grade is obj arg 1 as int(studentGrades)
                    //parameters arr[i] lists the data from the loop
                    Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
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
        }
}

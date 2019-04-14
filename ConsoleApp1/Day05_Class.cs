using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /*  Class is a blueprint for abstract values.
     *  For example, both Mercedez and Porsche are cars and can be driven.
     *  Here, car is a abstract value for Merceze and Prosche and being able to
     *  drive is the property of the car. And all of these are blue prints that defines a 
     *  abstract object called car. In Programming, Class represents the blueprint for the 
     *  data type, When you create the class, you design a new data type and the name of the class
     *  is the name of the type.
     */

     //This is the sample class called Student.
    class Student
    {
        //these are members of the class.
        //members can be either private, protected, public, internal, protected internal.
        //for setting members as private and making setter and getter methods in
        //properties are emcapsulation. it allows to hide important information of the
        //program.
        private string name;
        private int age;
        private double grade;
        private char GPA;

        //this is constructor of the class
        //it is only called once when an object is created
        //and it can be overloaded.
        public Student()
        {
            setName();
            setAge();
            setGrade();
            setGPA();
        }
        //overloading #1
        public Student(string name)
        {
            this.name = name;
            setAge();
            setGrade();
            setGPA();
        }
        //overloading #2
        public Student(int age)
        {
            setName();
            this.age = age;
            setGrade();
            setGPA();
        }
        //overloading#3
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            setGrade();
            setGPA();
        }

        //these are properties of the class.
        //Methods can also be with private or overloaded.
        public void setName()
        {
            Console.Write("Please Write the name >> ");
            name = Console.ReadLine();
        }

        public void setAge()
        {
            while (true)
            {
                try
                {
                    Console.Write("Please Set the age.");
                    age = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Write integer.");
                    continue;
                }
            }   
        }

        public void setGrade()
        {
            while (true)
            {
                try
                {
                    Console.Write("Please Set the grade.");
                    grade = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Write double.");
                    continue;
                }
            } 
        }

        public void setGPA()
        {
            GPA = (grade > 95.8) ? 'a' : (grade > 90.0) ? 'b' : (grade > 80.0) ? 'c' : (grade > 70.0) ? 'd' : 'f';
            //this is equivalent to below.
            if (grade > 95.8)
                GPA = 'a';
            else if (grade > 90.0)
                GPA = 'b';
            else if (grade > 80.0)
                GPA = 'c';
            else if (grade > 70.0)
                GPA = 'd';
            else
                GPA = 'f';
        }

        public void LogInfo()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Name: {0}", name);
            //this is equivalent to below.
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age: {0}", age);
            //or
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Grade   :  {0} : {1}", grade, GPA);
        }

    }

    class Day05_Class
    {

    }
}

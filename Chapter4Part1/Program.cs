using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
        string name;
        int age;
        string id;
        static string company = "add";

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
        }
        public Student(string name, int age, string id) : this(name, age)
        {
            this.id = company + id;
            Console.WriteLine(this.id);
        }
    }
}
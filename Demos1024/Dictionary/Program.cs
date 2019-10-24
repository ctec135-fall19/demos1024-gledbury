using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration
            Dictionary<string, Student> studentDictionary = new
                Dictionary<string, Student>();

            // initialize
            studentDictionary.Add("Bill", new Student("Bill1"));
            studentDictionary["Jill"] = new Student("Jill2");// another way to add
            studentDictionary["Jack"] = new Student("Jack3");

            // traversal
            foreach(string key in studentDictionary.Keys)//traverse keys
            {
                Console.WriteLine(key);

            }
            Console.WriteLine();

            foreach(Student s in studentDictionary.Values)//traverse values
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
        }
    }
}

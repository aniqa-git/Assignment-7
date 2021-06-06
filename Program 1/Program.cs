using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public void Introduce()
        {
            Console.WriteLine("Hello ! , My name is " + firstName + " " + lastName);
            Console.ReadLine();
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            var Thomas = new Person();
            Thomas.firstName = " Thomas";
            Thomas.lastName = " Newt";
            Thomas.Introduce();
        }
    }
}

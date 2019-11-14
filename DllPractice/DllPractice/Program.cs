using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Honor;
namespace DllPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student("monya", 25898, 3.68);
            Console.WriteLine(CheckHonor.Check(s1.gpa));
            Console.ReadLine();
        }
    }

    class student {
        public string name;
        public int id;
        public double gpa;

        public student() {
            name = "";
            id = 0;
            gpa = 0.0;

        }
        public student( string n, int i, double g)
        {
            name = n;
            id = i;
            gpa = g;
        }



    }
}

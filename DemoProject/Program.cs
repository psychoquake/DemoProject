using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://github.com/psychoquake/DemoProject
namespace DemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void fullname()//trying to push again :D
        {
            string fname = "Abhishek";
            string lname = "Jain";
            Console.WriteLine(fname + " " + lname);
        }

        public void fullname1()
        {
            string fname = "Aditya";
            string lname = "Gadekar";
            Console.WriteLine(fname + " " + lname);
        }
        public void fullname2()
        {
            string fname = "Akshitha";
            string lname = "Reddy";
            Console.WriteLine(fname + " " + lname);
        }
        public void fullname3()//vscode change
        {
            string fname = "Akshans";
            string lname = "Rautela";
            Console.WriteLine(fname + " " + lname);
        }
        public void autopush()
        {
            Console.WriteLine("The auto push from jenkins");
        }
        public void pushatfifty()
        {
            Console.WriteLine("will patienty wait for this push in jenkins at 11:50");
        }
    }
}

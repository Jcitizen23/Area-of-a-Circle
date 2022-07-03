using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sololearn
{
    class Programs
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            

            Console.WriteLine("input the area followed by the radius of your circle");
            radius = Convert.ToDouble(Console.ReadLine());
            double A = pi*(radius*radius); 
            Console.WriteLine("The area of your circle is {0}", A);
            
            


            

            

        }
    }
}
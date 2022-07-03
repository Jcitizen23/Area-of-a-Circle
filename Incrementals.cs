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
            //Declare variables and constant 
            const double pi = 3.14;
            double radius;
            
            //Ask user for the radius of their cirlce 
            Console.WriteLine("input the radius of your circle");
            //Convert raduius from a strong to a double when inputted by the user
            radius = Convert.ToDouble(Console.ReadLine());
            double A = pi*(radius*radius); 
            //Display the area of the circle to the screen 
            Console.WriteLine("The area of your circle is {0}", A);
            
            


            

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    class QuadraticQuation
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double x1, x2;


            double Discriminant = Math.Pow(b, 2) - (4 * a * c); //36-20=16

            if(Discriminant > 0){
                Console.WriteLine(Discriminant);
                x1 = (-b + Math.Sqrt(Discriminant)) / (2 * a); //-6+4/2*5=-2/10
                x2 = (-b - Math.Sqrt(Discriminant)) / (2 * a); //-6-4/2*5=-10/10 
                Console.WriteLine("Two real solutions: x1 = {0}, x2 = {1}",x1,x2);
                

            }else if(Discriminant < 0){

                Console.WriteLine("We have no real solution.");

            }else if(Discriminant == 0){
                x1 = (-b) / (2 * a);
                x2 = x1;
                Console.WriteLine("There is only one root x: {0}",x1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Surface_Area_Calculator
{
    public class CubeClass:ShapeInterface
    {
        double length;
        double area;
        double volume;
        List<string> cubeDetails = new List<string>();

       public CubeClass(double thelength)
       {
        length = thelength;
       }
       
        public double calculateArea()
       {
           area = 4 * Math.Pow(length, 2);
           return area;
       }

        public double calculateVolume()
        {
            volume = Math.Pow(length,3);
            return volume;
        }

         public List<string> addToList()
        {
            cubeDetails.Add("The Length of Cube Side is: " +length+"cm");
            cubeDetails.Add("The Surface Area of Cube is: " + area + "cm2");
            cubeDetails.Add("The Volume of Cube is: " + volume + "cm3");

            return cubeDetails;
        }
    }
}
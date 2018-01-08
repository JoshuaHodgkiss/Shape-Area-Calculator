using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Surface_Area_Calculator
{
    public class SphereClass:ShapeInterface
    {
        double radius;
        static double p = 3.414;
        double surfaceArea;
        double Volume;
        List<string> sphereDetails = new List<string>();

        public SphereClass(double theRadius)
        {
            radius = theRadius;
        }

        public double calculateArea()
        {
            surfaceArea = 4 *p*Math.Pow(radius,2);
            return surfaceArea;
        }

        public double calculateVolume()
        {
            Volume = (4 / 3) * p * Math.Pow(radius, 3);
            return Volume;
        }
        public List<string> addToList()
        {
            sphereDetails.Add("The Radius of the Sphere is: " + radius + "cm");
            sphereDetails.Add("The Surface Area of the Sphere is: " + surfaceArea + "cm2");
            sphereDetails.Add("The Volume of the Sphere is: " + Volume + "cm3");

            return sphereDetails;
        }
    }
}


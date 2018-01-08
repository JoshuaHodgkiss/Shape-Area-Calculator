using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Surface_Area_Calculator
{
    public class PyramidClass:ShapeInterface
    {
        double width;                       //The pyramid has 6 variables, 4 which are taken from the user, and two which are calculated using the 4 provided
        double height;              
        double length;
        double slant;
        double surfaceArea;                 //surfaceArea and Volume are calcuated using the other variables
        double Volume;
        List<string> pyramidDetails = new List<string>();  //new list which will display the pyramid details, general lists are also in the shapeInterface parent Class

        public PyramidClass(double thewidth, double theheight, double thelength, double theslant) //these 4 are provided by the webform
       {
        width = thewidth;
        height = theheight;
        length = thelength;
        slant = theslant;
       }


        public double calculateArea()
        {
            surfaceArea = 2*width*slant *Math.Pow(width, 2);      //looks complex, but is just the calculation for surface area. Math.Pow is just width to the power of 2 or width squared.
            return surfaceArea;
        }

        public double calculateVolume()
        {
            Volume =((length*width*height)/3);
            return Volume;
        }

        public List<string> addToList()
        {
            pyramidDetails.Add("The Length of Cube Side is: " + length + "cm");             //the specifics of the list, generic text added around the results of the above calulations.
            pyramidDetails.Add("The Surface Area of Cube is: " + surfaceArea + "cm2");
            pyramidDetails.Add("The Volume of Cube is: " + Volume + "cm3");

            return pyramidDetails;
        }
    }
}
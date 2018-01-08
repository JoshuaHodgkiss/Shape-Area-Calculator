using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Surface_Area_Calculator
{
    public partial class SurfaceAreaCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cube_Click(object sender, EventArgs e)
        {
            double cubeSide = Convert.ToDouble(sideCube.Text); //taking the textbox from the form where the user will enter data, and making it usable in the code here. For the cube we just need
                                                                //the actual length of a side from the user. we work out the rest.

            CubeClass theCube = new CubeClass(cubeSide); //estabilishing new constructor
            theCube.calculateArea();                    // calling the methods defined in the classes
            theCube.calculateVolume();

            List<string> cubeList = new List<string>(theCube.addToList()); //calling the method for displaying the results in a list.

            foreach (string measurement in cubeList)  //resultsCube is the name of the listbox where the results will be displayed.
            {
                resultsCube.Items.Add(measurement);
            }


        }

        protected void sphere_Click(object sender, EventArgs e)
        {
            double sphereRad = Convert.ToDouble(radiusSphere.Text); //taking the textbox from the form where the user will enter data, and making it usable in the code here. For the cube we just need
            //the actual length of a side from the user. we work out the rest.

            SphereClass theSphere = new SphereClass(sphereRad); //estabilishing new constructor
            theSphere.calculateArea();                    // calling the methods defined in the classes
            theSphere.calculateVolume();

            List<string> sphereList = new List<string>(theSphere.addToList()); //calling the method for displaying the results in a list.

            foreach (string measurement in sphereList)  //resultsCube is the name of the listbox where the results will be displayed.
            {
                resultsSphere.Items.Add(measurement);     //measurement can be anything, I choose measurement because the listbox will be displaying shape measurements.
            }
        }

        protected void pyramid_Click(object sender, EventArgs e)
        {
            double pyramidWidth = Convert.ToDouble(widthPyramid.Text);              //taking the infomation in the text boxes, converting it to doubles and giving it a name
            double pyramidHeight = Convert.ToDouble(heightPyramid.Text);
            double pyramidLength = Convert.ToDouble(sidePyramid.Text);
            double pyramidSlant = Convert.ToDouble(slantHeight.Text);


            PyramidClass thePyramid = new PyramidClass (pyramidWidth, pyramidHeight, pyramidLength, pyramidSlant); 
            thePyramid.calculateArea();                   //using the values given by the user above, this provides them to the arrays in the pyramidClass to calculate volume and surface area
            thePyramid.calculateVolume();

            List<string> pyramidList = new List<string>(thePyramid.addToList()); 

            foreach (string measurement in pyramidList)  
            {
                resultsPyramid.Items.Add(measurement);   
            }
        }
    }
}
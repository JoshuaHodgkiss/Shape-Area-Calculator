using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Surface_Area_Calculator
{
    public interface ShapeInterface
    {
        double calculateArea();
        double calculateVolume();
        List<string> addToList();

    }
}
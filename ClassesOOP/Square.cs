using System;
using System.Collections;
using System.IO;

namespace ClassesOOP
{
    class Square
    {

        public int numberOfSides = 4;
        double area;
        double perimeter;

        double sideLength;

        public Square()
        {
            this.numberOfSides =4;
            this.sideLength = 1;
            setcalcPerimeter(this.numberOfSides, this.sideLength);
            setcalcArea(this.sideLength);
            
        }

        void setcalcPerimeter(int Sides, double Length)
        {
            this.perimeter = (Sides *Length);
        }

        void setcalcArea(double length){
            this.area = (length * length);
        }

        //getter - a method that returns the value of a private (or otherwise) member or field

        public double getPerimeter()
        {
            return this.perimeter;
        }



    }

}
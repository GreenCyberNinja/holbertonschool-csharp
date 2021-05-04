using System;
using System.Collections.Generic;

///<summary> class shape has area</summary>
public class Shape
{
    ///<summary>method Area:currently doesn't work</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary>class Rectangle inherits from shape </summary>
public class Rectangle : Shape
{
    ///width of the rectangle
    private int width;
    ///height of the rectangle
    private int height;

    ///<summary>sets the width if greater than 0</summary>
    public int Width
    {
        get { return width; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }

    ///<summary>sets the height if greater than 0 </summary>
    public int Height
    {
        get { return height; }
        set 
        { 
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
                {
                height = value;
            }

        }
    }
    ///<summary>returns area of rectangle</summary>
    public new int Area()
    {
        return width * height;
    }
    ///<summary>returns new string rep of rectangle</summary>
    public override string ToString()
    {
        return ($"[Rectangle] {width} / {height}");
    }
}

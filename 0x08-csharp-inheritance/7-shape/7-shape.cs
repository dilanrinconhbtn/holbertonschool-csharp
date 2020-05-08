using System;

///<summary>class Shape</summary>
class Shape
{
    ///<summary>throw exception NotImplementedException</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
///<summary>class Rectangle : Shape</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    ///<summary>Width</summary>
    public int Width
    {
        get
        {
            return width;
        }
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
    //<summary>Height</summary>
    public int Height
    {
        get
        {
            return height;
        }
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
    //<summary>Area = height * width</summary>
    public override int Area()
    {
        return height * width;
    }
    //<summary>Tostring</summary>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}


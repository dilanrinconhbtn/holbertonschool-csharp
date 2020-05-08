using System;


class Shape
{
    ///<summary>throw exception NotImplementedException</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}


using System;
using System.Collections.Generic;


class Obj
{
    ///<summary>returns True if the object is an int, otherwise return False</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if(typeof(Array).IsInstanceOfType(obj))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        //Console.WriteLine(Object.ReferenceEquals(obj.GetType(), obj.GetType()));
        ///<summary>returns True if the object is an int, otherwise return False</summary>
        if(obj.GetType() == typeof(int))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

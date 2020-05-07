using System;
using System.Collections.Generic;


class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        //Console.WriteLine(Object.ReferenceEquals(obj.GetType(), obj.GetType()));

        

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


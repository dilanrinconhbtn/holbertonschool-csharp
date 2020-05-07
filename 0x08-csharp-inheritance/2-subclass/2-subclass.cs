using System;


class Obj
{
    ///<summary>returns True if is subclass</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if(derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        try
        {
            int i;
            for(i = 0; i < n; i++)
                Console.WriteLine(myList[i]);
            return i;
        }
        catch
        {
            return myList.Count;
        }
    }
}

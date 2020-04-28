using System;
using System.Collections.Generic;


class LList
{
    public static int Length(LinkedList<int> myList)
    {
        int counter = 0;
        foreach (int i in myList)
        {
            counter++;
        }
        return counter;
    }
}


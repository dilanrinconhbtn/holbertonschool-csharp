using System;
using System.Collections.Generic;


class List
{
    public static int Sum(List<int> myList)
    {
        var newList = new List<int>();
        var sum = 0;

        foreach (var num in myList)
        {
            if (!newList.Contains(num))
                newList.Add(num);
        }
        foreach (var num in newList)
            sum = sum + num;
        return (sum);
    }
}
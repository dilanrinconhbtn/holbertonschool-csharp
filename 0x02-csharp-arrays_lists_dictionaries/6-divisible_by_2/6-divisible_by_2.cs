using System;
using System.Collections.Generic;

class List {
    public static List<bool> DivisibleBy2(List<int> myList) {
        List<bool> myList1 = new List<bool>();
        for (int i = 0; i < myList.Count; i++)
        {
            if(myList[i] % 2 == 0)
            {
                myList1.Add(true);
            }
            else
            {
                myList1.Add(false);
            }
        }
        return myList1;
    }
}
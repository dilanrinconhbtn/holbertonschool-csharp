﻿using System;
using System.Collections.Generic;

class List {
    public static int MaxInteger (List<int> myList) {
        if (myList.Count > 0)
        {
            int max = myList[0];
            for (int i = 0; i < myList.Count; i++)
            {
                if(max < myList[i])
                {
                    max = myList[i];
                }
            }
            return max;
        }
        else
        {
            Console.WriteLine("List is empty");
            return -1;
        }
    }
}
using System;
using System.Collections.Generic;

class List {
    public static List<int> CreatePrint (int size) {
        List<int> Nlist = new List<int>();
        if(size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if(size == 0)
        {
            Console.WriteLine();
	        return Nlist;
        }
        else
        {
            for(int i=0; i < size;i++) 
            {
                if(i != size-1)
                    Console.Write("{0} ",i);
                else
                    Console.Write(i);
                Nlist.Add(i); 
            }
            Console.WriteLine();
            return Nlist;
        }
    }
}
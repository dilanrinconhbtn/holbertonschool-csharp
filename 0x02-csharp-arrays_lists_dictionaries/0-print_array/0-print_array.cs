using System;

class Array {
    public static int[] CreatePrint (int size) {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        } else {
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++) {
                numbers[i] = i;
                if (i != size - 1) {
                    Console.Write("{0} ", numbers[i]);
                } else {
                    Console.Write("{0}\n", numbers[i]);
                }
            }
            return numbers;
        }
    }
}
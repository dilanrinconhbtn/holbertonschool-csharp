using System;


class Number
{
    public static int PrintLastDigit(int number)
    {
        if(number < 0)
        {
            number = number * -1;
        }
        int last = number % 10;
        Console.Write("{0}", last);
        return last;
    }
}


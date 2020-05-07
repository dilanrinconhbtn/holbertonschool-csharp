# C# - Inheritance

##  0. This is one of these mandatory

Write a method that returns True if the object is an int, otherwise return False.

    Class: Obj
    Prototype: public static bool IsOfTypeInt(object obj)


##  1. For instance mandatory

Write a method that returns True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False.

    Class: Obj
    Prototype: public static bool IsInstanceOfArray(object obj)


##  2. Only subclass mandatory

Write a method that returns True if the object is an instance of a class that inherits from the specified class, otherwise return False. The object must be a subclass; your method cannot return True if the object is an instance of the base class.

    Class: Obj
    Prototype: public static bool IsOnlyASubclass(Type derivedType, Type baseType)


##  3. Type mandatory

Write a method that prints the names of the available properties and methods of an object. See example for output format.

    Class: Obj
    Prototype: public static void Print(object myObj)


##  4. It's not a lesson in classes and inheritance without a Dog mandatory

Write a empty class Dog that inherits from empty class Animal.

    Base Class: Animal
    Derived Class: Dog


##  5. Basic shapes mandatory

Write a class Shape.

    Class: Shape
        public method: public virtual int Area()
            Throws an NotImplementedException with the message Area() is not implemented


##   6. Rectangle mandatory

Based on 5-shape, write a class Rectangle that inherits from Shape.

    Class: Rectangle
        private field: private int width
        private field: private int height
        public property: public int Width
            get: retrieve width
            set: if value is negative, throw an ArgumentException with the message Width must be greater than or equal to 0. Otherwise, set width to the value.
        public property: public int Height
            get: retrieve height
            set: if value is negative, throw an ArgumentException with the message Height must be greater than or equal to 0. Otherwise, set Height to the value.


##  7. Full rectangle mandatory

Based on 6-shape, write a class Rectangle that inherits from Shape.

    Class: Rectangle
        private field: private int width
        private field: private int height
        public property: public int Width
            get: retrieve width
            set: if value is negative, throw an ArgumentException with the message Width must be greater than or equal to 0. Otherwise, set width to the value.
        public property: public int Height
            get: retrieve height
            set: if value is negative, throw an ArgumentException with the message Height must be greater than or equal to 0. Otherwise, set Height to the value.
        public method: public new int Area()
            This will override the Area() method defined in the Shape base class. (Try changing new to override and run the program. What happens?) returns the area of the rectangle
        public method: public override ToString()
            returns [Rectangle] <width> / <height>


##  8. Square #1 mandatory

Based on 7-shape, write a class Square that inherits from Rectangle

    Class: Square
        private field: private int size
        public property: public int Size
            get: retrieve size
            set: if value is negative, throw an ArgumentException with the message Size must be greater than or equal to 0. Otherwise, set size, height, and width to the value.


## 9. Square #2 mandatory

Based on 8-shape, write a class Square that inherits from Rectangle

    Class: Square
        private field: private int size
        public property: public int Size
            get: retrieve size
            set: if value is negative, throw an ArgumentException with the message Size must be greater than or equal to 0. Otherwise, set size, Height, and Width to the value.
        Area() should work without writing a new Area() method within your Square class
        .ToString() should return [Square] <size> / <size>


##   10. Liskov mandatory

In the previous tasks, we created a class Square that inherits from Rectangle. However, what happens if you try to assign a Square’s width and height directly:

using System;

class Program
{
    static void Main(string[] args)
    {
        Square aSquare = new Square();

        try
        {
            aSquare.Width = 12;
            aSquare.Height = 8;

            Console.WriteLine("aSquare width: {0}", aSquare.Width);
            Console.WriteLine("aSquare height: {0}", aSquare.Height);
            Console.WriteLine("aSquare size: {0}", aSquare.Size);
            Console.WriteLine("aSquare area: {0}", aSquare.Area());
            Console.WriteLine(aSquare.ToString());
        }
        catch (Exception e)
        {            
            Console.WriteLine(e);
        }
    }
}

Here we see there’s a flaw in our implementation of Square as inheriting from Rectangle. This is because this hierarchy violates Liskov’s substitution principle. What would the ideal hierarchy involving Shape, Rectangle, and Square look like instead?

Write a blog post that explains the problem with implementing a Square class as a derived class of Rectangle. It should cover:

    what Liskov’s substitution principle is
    why Square inheriting from Rectangle is not an ideal design choice
    ways that this class hierarchy could be improved

Your posts should have examples and at least one picture, at the top. Publish your blog post on Medium or LinkedIn, and share it at least on Twitter and LinkedIn.

Please, remember that these blogs must be written in English to further your technical ability in a variety of settings.
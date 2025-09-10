namespace moduule1review;

class Program
{
    //method that calculates the area of a circle
    public static double CalculateArea(double radius)
    {
    //math that calculates area of circle
        return Math.PI * radius * radius; // to find area of a circle area = PI *radius * radius
    }
    
    
    //method that calculates the area of a triangle
    public static double CalAreaT(double baseLength, double height)
    {
        //math that calculates area of triangle
        return (baseLength * height / 2);
            
    }
    
    
    
    //method that calculates the area of a rectangle
    public static double CalAreaR(double length, double width)
    {
        //math for area of rectangle
        return  length * width; 
    }
    
    
    
    //method that calculates the area of a square
    public static double CalAreaS(double side)
    {
        //math for area of square
        return side * side;
    }
    
    
    
    
    
    
    
    
    
        
    
    
    
    static void Main(string[] args)
    {
       
        
        
        
        Console.WriteLine("Hello user when your run this code you should be able to calculate the area of a given shapes using variables you have");
       // Console.WriteLine("you may choose between a Circle, Triangle, Rectangle or Square");
            

        //asking user for radius and answering for circle
        Console.WriteLine("enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine()); // 
        double areaofC = CalculateArea(radius); // calling circle method back to main
        Console.WriteLine($"area is {areaofC}");
       
        
        //asking user for the hight, baselength and answering for triangle
        Console.WriteLine("enter the height of the triangle:");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("enter the bacelength of the triangle:");
        double baseLength = double.Parse(Console.ReadLine());
        double areaoft = CalAreaT(baseLength, height); //calling triangle method to main
        Console.WriteLine($"area is {areaoft}");
        
        
        //asking user for the length,width and answering for rectangle
        Console.WriteLine("enter the length of the rectangle:");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("enter the width of the rectangle:");
        double width = double.Parse(Console.ReadLine());
        double areaofR= CalAreaR(length, width);  //calling triangle method to main
        Console.WriteLine($"area is {areaofR}");


        //asking user for the  side length and answering for square
        
        Console.WriteLine("enter the side length of the square:");
        double sidelength = double.Parse(Console.ReadLine());
        double areaofS = CalAreaS(sidelength);  //calling triangle method to main
        Console.WriteLine($"area is {areaofS}");
        
        
        
        
        
        
        
        
    }
}
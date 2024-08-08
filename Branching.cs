    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Branching 
    {
    class program 
    {
    static void Main(string[] args)
    {
    //The user must then be prompted for the package weight.
    double weigth= 0.00;
    //The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
    Console.Write("Welcome to Package Express, Please follow the instruction below.");
    Console.ReadLine();
    Console.WriteLine("Please Enter The Package weigth");
    int currentweight = Convert.ToInt32(Console.ReadLine());
    //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.
    if (currentweight + weigth < 50)
        {
        Console.WriteLine("Please Enter The Package width");
        }
        else 
        {
        Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
        }
    //The user must then be prompted for the package width.
     double width= 0.00;
     int currentwidth = Convert.ToInt32(Console.ReadLine());
    //If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
     if (currentwidth + width < 50)
        {
        Console.WriteLine("Please Enter The Package heigth");
        }
        else 
        {
        Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
        }
     //Then the package height.
     double heigth= 0.00;
     int currentheigth = Convert.ToInt32(Console.ReadLine());

     if (currentheigth + heigth < 50)
        {
        Console.WriteLine("Please Enter The Package length");
        }
        else 
        {
        Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
        }
    
    //Then the package length.
     double length= 0.00;
     int currentlength = Convert.ToInt32(Console.ReadLine());

     if (currentlength + length < 50)
        {
        //Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
        double C = currentheigth * currentwidth * currentlength * currentweight / 100;
        //The result of that calculation is the quote.
        Console.WriteLine($"Your estimated total for shipping this package is: ${C:F2}");
        //Display the quote to the user as a dollar amount.
        Console.WriteLine("Thank you");
        }
        else 
        {
        Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
        }
        Console.ReadLine();

    }
    }
    }
 


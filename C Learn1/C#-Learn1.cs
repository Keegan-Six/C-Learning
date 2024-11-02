// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Security.AccessControl;

/* Resources
   https://www.w3schools.com/cs/index.php (14+)
   https://www.learncs.org/en/Welcome (1-13)
*/
public class Hello
{
    //variables
    /*
    int myInt = 1;
    float myFloat = 1f;
    bool myBoolean = true;
    string myName = "John";
    char myChar = 'a';
    double myDouble = 1.75;
    */

// enum is a class used to reprsent a group of constants, for 3
public enum CarType
{
    Toyota = 1,
    Honda = 2,
    Ford = 3,
}
// Method for 11
public static int Multiply(int a, int b)
{
    return a * b;

}
// Class for 12
class Car {
    int numtires = 4;
    int year = 2000;
    bool runs = true;

}
// Class for 13
class Shape{
    public string Type;
    public int Sides;
    public int Sidelength;
    public double Area;  
    public Shape(string type, int sides, int sidelength, double area){
        Type = type;
        Sides = sides;
        Sidelength = sidelength;
        Area = area;
  }
}
// Class for 14
class Person
{
  private string name; // field
  public string Name   // property
  {
    get { return name; }
    set { name = value; }
  }
}
// Vehicle and Car for 15
class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}
class Car2 : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car2 field
}
// Animals for 16
// virtual keyword + overide command allows child classes to overide base methods
class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}
    public static void Main()
    {
        // 1 Writing to console
        System.Console.WriteLine("Hello!");
        System.Console.WriteLine("Goodbye, World!");

        // 2 Scanners
        Console.WriteLine(Console.ReadLine());

        // 3 enums, variables, and casting
        CarType Car = CarType.Toyota;
        System.Console.WriteLine(Car);
        Car = (CarType)(3);
        System.Console.WriteLine(Car);

        // 4 Converting Types and casting 2
        int myvar = (int) 1.0;
        string myvar2 = Convert.ToString(10);

        // 5 Conditonals
        int guess = 500;
        if (guess == 500) {
            Console.WriteLine("You Win!");
        }
        else {
            Console.WriteLine("what");
        }
        // 6 arrays (similiar to C)
        int[] nums = { 1, 2 , 3, 4, 5};
        int[] nums2 = new int[10];
        Console.WriteLine(nums2.Length);

        int[,] matrix = new int[2,2];

        matrix[0,0] = 1;
        matrix[0,1] = 2;
        matrix[1,0] = 3;
        matrix[1,1] = 4;

        // 7 Lists
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Remove(1);
        numbers.Add(2);
        numbers.AddRange(nums);
        numbers.RemoveAt(2);

        // 8 Dictionary
        // New: a list where every value in the list has a key which is also a variable.

        Dictionary<string, long> phonebook = new Dictionary<string, long>();
        phonebook.Add("Keegan", 3197205878);
        phonebook["Jessica"] = 3196703426;

        if (phonebook.ContainsKey("Keegan"))
        {
            Console.WriteLine("Keegan's number is " + phonebook["Keegan"]);
        }
        phonebook.Remove("Jessica");

        // 9 Strings
        string firstname = "Keegan ";
        string lastname = "Smith";
        string fullname = firstname += lastname;
        Console.WriteLine(fullname);
        int one = 1;
        String conversion = one.ToString();
        string sub1 = fullname.Substring(5);
        string sub2 = fullname.Substring(1,5);
        string sister = fullname.Replace("Keegan", "Lauren");
        int where = fullname.IndexOf("Keegan");

        //10 Loops (similiar to C)
        for (int i = 0; i < 10; i++) {
            if (i == 5)
            {
                break;
            }
        }
        string[] programming = {"C++", "C#", "CPython", "C", "Java", "JavaScript"}; //An array

        foreach (string language in programming)
        {
            Console.WriteLine(language);
        }

        int n = 0;

        while(n == 0)
        {
            Console.WriteLine("N is 0");
            n++;
        }

        // 11 Methods (similair to Java)
        int product = Multiply(5,5);
        Console.WriteLine(product);

        // 12 Classes
        Car car1 = new Car();
        Car car2 = new Car();
        Car car3 = new Car();

        // 13 Class Variables
        Shape square = new Shape("square", 4, 1, 1);
        Shape bigsquare = new Shape("square", 4, 2, 4);
        Shape triangle = new Shape("triangle", 3, 3, 3.9);
        Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", square.Type, square.Sides, square.Sidelength, square.Area);
        Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", bigsquare.Type, bigsquare.Sides, bigsquare.Sidelength, bigsquare.Area);
        Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", triangle.Type, triangle.Sides, triangle.Sidelength, triangle.Area);

        // 14 Class Properties
        Person Keegan = new Person();
        Keegan.Name = "Keegan";
        Console.WriteLine(Keegan.Name);
        
        // 15 Inheritance
        Car2 myCar = new Car2();
        myCar.honk();
        Console.WriteLine(myCar.brand + " " + myCar.modelName);

        // 16 Polymorphism
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object
        Animal myDog = new Dog();  // Create a Dog object

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();

        // check C-Learn2 for more


  }
}

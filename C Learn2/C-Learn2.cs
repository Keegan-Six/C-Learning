// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
// interfaces
// to implement muiltiple interfaces, use a comma.
interface Animal 
{
  void animalSound(); // interface method (does not have a body)
  void run(); // interface method (does not have a body)
}
class Pig : Animal // put comma here if using muiltiple
{
  public void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
  public void run()
    {
        Console.WriteLine("vroooooooooom");
    }
}

class Program 
{
  static void Main(string[] args) 
  {
    // 1 Interfaces
    Pig myPig = new Pig();  // Create a Pig object
    myPig.animalSound();
    myPig.run();

    // 2 Files
    // files are in bin
    /* File Methods
       Append Text() add text to end of file
       Copy() copy file
       Create() create file
       Delete() delete file
       Exists() check if file exists
       ReadAllText() read the content of the file
       Replace() overwrite a file
       WriteAllText() creates a new file and writes content to it
    */
    string writeText = "Hello World!";
    File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

    string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
    Console.WriteLine(readText);  // Output the content

    // 3 Exceptions
    
  }

}
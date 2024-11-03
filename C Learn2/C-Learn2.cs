
// resources
// https://www.w3schools.com/cs/index.php
// https://www.geeksforgeeks.org/c-sharp-queue-class/
// https://www.geeksforgeeks.org/c-sharp-stack-class/
// https://www.geeksforgeeks.org/linked-list-implementation-in-c-sharp/
using System;
using System.IO;
using System.Collections;
using System.Runtime.CompilerServices;
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
  try
  {
    int[] myNumbers = {1, 2, 3};
    Console.WriteLine(myNumbers[10]);
  }
  catch (Exception e)
  {
    Console.WriteLine("Something went wrong.");
  }
  finally // initiates regardless of result
  {
    Console.WriteLine("The 'try catch' is finished.");
  }
  // 4 Queues
  // first in, first out
  // 
  // Creating a Queue 
        Queue myQueue = new Queue(); 
  
        // Inserting the elements into the Queue 
        myQueue.Enqueue("Keegan"); 
        myQueue.Enqueue("Paul"); 
        myQueue.Enqueue("Sam"); 
        myQueue.Enqueue("Michael"); 
        myQueue.Enqueue("Campbell"); 
        myQueue.Enqueue("Adam"); 

        // removes oldest elements
        myQueue.Dequeue(); // keegan
        myQueue.Dequeue(); // paul

        // looks at oldest element but does not remove
        Console.WriteLine(myQueue.Peek());
  
        // Displaying the count of elements 
        // contained in the Queue 
        Console.Write("Total number of elements in the Queue are : "); 
        Console.WriteLine(myQueue.Count); 

        // Converting the Queue 
        // into object array 
        Object[] arr = myQueue.ToArray(); 
  
        // Displaying the elements in array 
        foreach(Object obj in arr) 
        { 
            Console.WriteLine(obj); 
        } 
        // Creates a shallow copy of the queue (pointers)
        // myQueue.Clone();

        // creates deep copy of queue
        Queue newQueue = new Queue(myQueue);

        // removes all object from queue
        myQueue.Clear();

        // determines whether a element contains a element (boolean)
        Console.WriteLine(newQueue.Contains("Adam"));

        // gets an iterator
        newQueue.GetEnumerator();
    // 5 Stacks
    // last-in first out
      
        // Creating a Stack 
        Stack myStack = new Stack(); 
  
        // Inserting the elements into the Stack 
        myStack.Push("1"); 
        myStack.Push("2"); 
        myStack.Push("3"); 
        myStack.Push("4"); 
        myStack.Push("5"); 
        myStack.Push("6"); 
  
        // Displaying the count of elements 
        // contained in the Stack 
        Console.Write("Total number of elements in the Stack are : "); 
  
        Console.WriteLine(myStack.Count); 
  
        // Displaying the top element of Stack 
        // and removing it from the Stack 
        Console.WriteLine("Element at the top is : " + myStack.Pop()); 
  
        // Displaying the top element of Stack 
        // without removing it from the Stack 
        Console.WriteLine("New element at the top is : " + myStack.Peek()); 
  
        // Displaying the count of elements 
        // contained in the Stack 
        Console.Write("Total number of elements in the Stack are : "); 
        Console.WriteLine(myStack.Count);

        // also has clear, clone, and contain methods

    // 6 linked lists
    // elements in a linked list are linked via pointers

        // Creating a linkedlist
        // Using LinkedList class
        LinkedList<String> my_list = new LinkedList<String>();
 
        // Adding elements in the Linkedlist
        // Using AddLast() method
        // also AddFirst(), AddAfter(), and AddBefore()
        my_list.AddLast("Keegan");
        my_list.AddLast("Paul");
        my_list.AddLast("Sam");
        my_list.AddLast("Campbell");
        my_list.AddLast("Adam");
 
        // removing elements
        // also Remove(T) (value), and Remove(LinkedListNode) (Node)
        my_list.RemoveFirst(); // removes Keegan
        my_list.RemoveLast(); // removes Adam

        // Check if the given element
        // is available or not
        if (my_list.Contains("Keegan") == true) 
        {
            Console.WriteLine("Element Found...!!");
        }
        else
        {
            Console.WriteLine("Element Not found...!!");
        }
    // 7 Search Algorithms
    // BFS:  https://www.geeksforgeeks.org/breadth-first-search-or-bfs-for-a-graph/
    // DFS: https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/

    // 8 Sorting Algorithms
    // https://www.geeksforgeeks.org/sorting-algorithms/

    } 

}
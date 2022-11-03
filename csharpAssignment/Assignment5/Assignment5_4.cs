using System;
using System.Collections;

class Fourth
{

    static public void Main()
    {

        Stack my_stack = new Stack();
        my_stack.Push("Mumbai");
        my_stack.Push("pune");
        my_stack.Push("goa");
        my_stack.Push("delhi");

        Console.WriteLine("Total elements present in" + " my_stack: {0}", my_stack.Count);

        my_stack.Pop();
        Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Count);


        my_stack.Clear();

        // After Pop method
        Console.WriteLine("Total elements present in " +
                      "my_stack: {0}", my_stack.Count);

    }
}



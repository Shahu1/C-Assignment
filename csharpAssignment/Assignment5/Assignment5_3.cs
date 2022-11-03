using System;
using System.Collections.Generic;

class Third
{


    static public void Main()
    {


        LinkedList<String> my_list = new LinkedList<String>();

        // Adding elements in the LinkedList
        // Using AddLast() method
        my_list.AddLast("Shahista");
        my_list.AddLast("Nidhi");
        my_list.AddLast("kajal");
        my_list.AddLast("poonam");
        my_list.AddLast("saloni");
        my_list.AddLast("Divya");


        Console.WriteLine("Name of employees:");


        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("Number of employees: {0}", my_list.Count);
        if (my_list.Contains("Shahista") == true)
        {
            Console.WriteLine("Element Found...!!");
        }
        else
        {
            Console.WriteLine("Element Not found...!!");
        }


    }
}

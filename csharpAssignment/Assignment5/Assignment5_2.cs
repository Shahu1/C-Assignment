using System;
using System.Collections;
namespace Second
{
    class Employee
    {
        public static void Main(String[] args)
        {
            ArrayList arlist = new ArrayList()
        {
                            1,
                            "Shahista",
                            300000,
                            "Mumbai"
        };


            for (int i = 0; i < arlist.Count; i++)


                Console.Write(arlist[i] + ", ");
        }
    }
}
}


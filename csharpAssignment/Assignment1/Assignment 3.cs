using System;

namespace Assignmentno3
{
    class Program
    {
        public static int Addo(params int[] names)
        {
            int sum = 0;
            foreach (int name in names)
            {
                Console.WriteLine("Your Values " + name);
            }
           
            for (int i = 0; i < names.Length; i++)
            {
                sum += names[i];
            }




            return sum;

        }
       

        public static void Main(String[] args)
        
        {
            Addo(1, 2, 3, 4);
            Console.ReadLine();
        }
        
   

     }

 }
       

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment
{
    class Generic
    {
        public static void Main(string[] args)
        {
            Mycollection<int> mycollection = new Mycollection<int>();
            int[] items = new int[10]; 
       
            Console.WriteLine("Enter the 10 values: ");
            for (int counter = 0; counter < 10; counter++)
            items[counter] =Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Enter the index of the item to be displayed");
            int index = Convert.ToInt16(Console.ReadLine());
            
            if (index < 0 && index >-10)
            mycollection[index] = items[10+index];
            else
                mycollection[index] = items[index];
                
            Console.WriteLine("Your value at index {0} = " , index);
            Console.WriteLine(mycollection[index]);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment
{
    class Mycollection<T>
    {
        public T[] list = new T[10];
        public T this[int index]
        {
            get
            {
                if (index < 0 && index > -10)
                    return list[9];
                else
                    return list[index];
                
            }
            set
            {
                if (index >= 0 && index <= 10)
                {
                    list[index] = value;
                }
                else if (i < 0 && i > -10)
                {
                    list[9] = value;
                }
                else
                    Console.WriteLine("Out of Bounds!");
            }
        }
    }
}

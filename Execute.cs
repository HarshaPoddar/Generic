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
        public T this[int i]
        {
            get
            {
                if (i < 0 && i > -10)
                    return list[9];
                else
                    return list[i];
                
            }
            set
            {
                if (i >= 0 && i <=10)
                {
                    list[i] = value;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class RakList<T>
    {
        T [] data;
        int count;
        int capacity;

        public RakList()
        {
            count = 0;
            capacity = 5;
            data = new T [capacity];
            
        }

        public void Add(T value)
        {
            
            
        }

        public void Remove(T value)
        {
            
        }
    }
}

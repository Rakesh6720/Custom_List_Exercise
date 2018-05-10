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
            data = new T [5];
            capacity = 5;
        }

        public void Add(T value)
        {
            
            
        }

        public void Remove(T value)
        {
            
        }
    }
}

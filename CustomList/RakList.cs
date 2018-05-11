using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class RakList<T> : IEnumerable<T>
    {
        T [] array;
        int count;
        int capacity;

        public RakList()
        {
            count = 0;
            capacity += 5;
            array = new T [capacity];
        }

        public T this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // how to enumerate
            return (IEnumerator)GetEnumerator();

        }
        public IEnumerator<T> GetEnumerator()
        {
            // how to enumerator
        }

        public bool CheckCapacity(int count, int capacity)
        {
            if (count > capacity)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Add(T value)
        {
            bool trueFalse = CheckCapacity(count, capacity);
            if (trueFalse == true)
            {
                array[count] = value;
            }
            else
            {
                capacity = capacity * 2;
                T [] tempArray = new T [capacity];

               for (int i = 0; i<=count; i++)
                {
                    tempArray[i] = array[i];
                }

                array = tempArray;
                
            }
            
        }

        public void Remove(T value)
        {

        }
    }
}

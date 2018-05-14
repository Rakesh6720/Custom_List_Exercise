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
           for (int index = 0; array.Length < count; index++)
            {
                yield return array[index];
            } 
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

       public bool CheckItem(T value)
        {
            //Check if item exists
            bool isTrue = false;

            for (int i = 0; i < count; i++)
            {
                if (array[i] == value)
                {
                    isTrue = true;
                    
                }
                else
                {
                   isTrue = false;
                    
                }
            }
            return isTrue;
        }
        public void Remove(T value)
        {
            bool isTrue = CheckItem(value);
            if (isTrue == true)
            {
                for (int i = 0; i < count; i++)
                {
                    if (array[i] == value)
                    {
                        array[i] = array[i + 1];
                        count--;
                        int cycle = 0;
                        int nextIndex = i + 1;
                        while (cycle < count)
                        {
                            array[nextIndex] = array[nextIndex++];
                            cycle++;
                        }
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine(value + " cannot be found in List.");
            }
        }

        public override string ToString()
        {
            string newString = " ";

            for (int i = 0; i<count; i++)
            {
                newString += array[i];
            }
            return newString;
        }

        public static RakList<T> operator + (RakList<T> list1, RakList<T> list2)
        {
            RakList<T> jointList = new RakList<T>();
            foreach (T item in list1)
            {
                jointList.Add(item);
            }
            foreach(T item in list2)
            {
                jointList.Add(item);
            }
            return jointList;
        }
    }
}

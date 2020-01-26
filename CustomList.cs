using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        // ------------------------------------------------member variables (HAS A)-----------------------------------
        T[] items;

        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

      
        public T this[int i] // Indexer
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }      
        //---------------------------------------------constructor(SPAWNER)---------------------------------------------
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        // --------------------------------------------member methods (CAN DO)-------------------------------------------


        public void Add(T itemToAdd)
        {
            if (Count == Capacity)
            {
                capacity *= 2;
                T[] tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = new T[capacity];
                for (int j = 0; j < count; j++)
                {
                    items[j] = tempArray[j];
                }
            }
            items[count] = itemToAdd;
            count++;
            // should add a value to our list (to the end)
            // increment count
        }
    }
}

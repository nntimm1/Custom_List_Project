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

                                             //-----------Add Method------------
        public void Add(T itemToAdd)
        {
            if (Count == Capacity)
            {
                capacity *= 2;                            // will double capacity if the count is equal to the capacity
                T[] tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {                                         // will assign items from the original array to the new temp array in the original index
                    tempArray[i] = items[i];
                }
                items = new T[capacity];                  // creates a new array with the updated capacity 
                for (int j = 0; j < count; j++)           
                {
                    items[j] = tempArray[j];              // moves items from temp array to the new array in the original index position
                }
            }
            items[count] = itemToAdd;                     // should add a value to our array int he last position
            count++;                                      // increases the count value by one
        }




                                            //-----------Remove Method------------       
        public void Remove()
        {

        }
    }
}

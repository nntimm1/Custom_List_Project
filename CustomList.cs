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
            set
            {
                count = value;
            }
        }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
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
            items[count] = itemToAdd;                     // should add a value to our array in the last position
            count++;                                      // increases the count value by one
        }




                                            //-----------Remove Method------------       
        public void Remove(T itemToRemove)
        {
            for (int i = 0; i < Count; i++)
            {
                if (!items[i].Equals(itemToRemove))             // if item in index i is equal to itemToRemove
                {
                    T[] tempArray = new T[Capacity];
                    for (int j = i; j < Count; j++)            // building temp array
                    {
                        tempArray[j] = items[i];           // j-1 does not work on the remove incorrect item test because the first item is not removed. j does ot work if the first item is removed. 
                                                           



                        i++;                                         // added a ++ to i and it rewrote over index 0 with tango
                        if (items[i].Equals(itemToRemove))    // if index j is not equal to item to remove
                        {                                      // then add it to the new temp array
                                                               // added ++ to j and it put delta in index 0 to 2

                            tempArray[j] = items[i];          // added ++ to j and it skip[ped index 1 and put delta in index 0 and 2

                        }                       // added ++ to j and it skipped index 1 abd put delta in index 0 and 2


                    }
                    items = new T[capacity];                   // creates a new array without itemToRemove 
                    for (int k = 0; k < count; k++)
                    {
                        items[k] = tempArray[k];               // moves items from temp array to the new
                    }                                          // array in the new index position
                }                                              
            }                                         

        }

        public void Remove2(T itemToRemove)
        {
            T[] tempArray = new T[Capacity];
            bool haveRemovedItem = false;
            int indexToGrabValueFrom = 0;
            
            for (int i = 0; i < Count; i++)
            {
                if (!items[i].Equals(itemToRemove) && !haveRemovedItem)             // if item in index i is equal to itemToRemove
                {
                    tempArray[i] = items[indexToGrabValueFrom];
                
                    // array in the new index position
                }
                else if(items[i].Equals(itemToRemove))
                {
                    haveRemovedItem = true;
                    indexToGrabValueFrom++;
                    Count--;
                }
                else // if not the item to remove, but we have already removed an item
                {
                    tempArray[i] = items[indexToGrabValueFrom];
                    
                }

                tempArray[i] = items[indexToGrabValueFrom];
                indexToGrabValueFrom++;
                
            }
            

            items = tempArray;     // creates a new array without itemToRemove 

        }

    }
}

                        //if (items[i++].Equals(itemToRemove))    // if index j is not equal to item to remove
                        //{                                      // then add it to the new temp array
                        //                                        // added ++ to j and it put delta in index 0 to 2

                        //    tempArray[j] = items[i];          // added ++ to j and it skip[ped index 1 and put delta in index 0 and 2

                        //}
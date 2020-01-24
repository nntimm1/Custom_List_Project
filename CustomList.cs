using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
                // Member vaiable
        T[] items;
        public  int count;
        public int capacity;
        
        private T[] array = new T[4];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }

        }

        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[0];
        }




        //member methods
        public void Add(T itemToAdd)
        {
            items[0] = itemToAdd;
            // should add a value to our list (to the end)
            // increment count
        }
    }
}

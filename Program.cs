using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
     class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> testList = new CustomList<int>();

            CustomList<int> customList1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6 };

            CustomList<int> result = customList1 - customList2;

            result.Zip(customList1, customList2);
            Console.ReadLine();

            

        }
      
    }
}
   


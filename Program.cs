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

            CustomList<int> customList1 = new CustomList<int>() { 55, 85, 115, 35, 95 };
            CustomList<int> customList2 = new CustomList<int>() { 75, 65, 45, 105, 125 };

            CustomList<int> result = customList1 + customList2;

            
            Console.ReadLine();



        }
      
    }
}
   


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
            CustomList<int> test = new CustomList<int>();

            test.Add(1);
            test.Add(2);
            test.Add(3);

            test.Remove2(2);

            
        }
      
    }
}
   


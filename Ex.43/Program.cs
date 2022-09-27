using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex._43
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] array = {0, 1, 2, 3, 4, 5};
            Lord.WriteArray(array);

            Lord.Resize(ref array, 4);
            Lord.WriteArray(array);

            Lord.AddToTop(ref array, 4);
            Lord.WriteArray(array);

            Lord.AddToEnd(ref array, 5);
            Lord.WriteArray(array);

            Lord.AddByIndex(ref array, 5, 4);
            Lord.WriteArray(array);

            Lord.DeleteFirstElement(ref array);
            Lord.WriteArray(array);

            Lord.DeleteLastElement(ref array);
            Lord.WriteArray(array);

            Lord.DeleteByIndex(ref array, 3);
            Lord.WriteArray(array);
        }
    }
}

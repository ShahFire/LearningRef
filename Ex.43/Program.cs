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
            Console.WriteLine($"Проверка с типом string \n\n");

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

            Console.WriteLine($"\n\n Проверка с типом string \n\n");

            string[] array2 = { "Маша", "Даша", "Глаша", "Иван", "Петя", "Коля" };
            Lord.WriteArray(array2);

            Lord.Resize(ref array2, 4);
            Lord.WriteArray(array2);

            Lord.AddToTop(ref array2, "Артур");
            Lord.WriteArray(array2);

            Lord.AddToEnd(ref array2, "Стапен");
            Lord.WriteArray(array2);

            Lord.AddByIndex(ref array2, 5, "Зоя");
            Lord.WriteArray(array2);

            Lord.DeleteFirstElement(ref array2);
            Lord.WriteArray(array2);

            Lord.DeleteLastElement(ref array2);
            Lord.WriteArray(array2);

            Lord.DeleteByIndex(ref array2, 3);
            Lord.WriteArray(array2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex._43
{
    internal class Lord
    {
        public static void DeleteByIndex<T>(ref T[] array, int index)
        {
            if (array.Length > index && index >= 0)
            {
                T[] newArray = new T[array.Length - 1];

                for (int i = 0, j = 0; i < newArray.Length; i++, j++)
                {
                    if (j == index) i--;
                    else newArray[i] = array[j];
                }

                array = newArray;
            }
        }
        public static void DeleteLastElement<T>(ref T[] array)
        {
            T[] newArray = new T[array.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        public static void DeleteFirstElement<T>(ref T[] array)
        {
            T[] newArray = new T[array.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }

            array = newArray;
        }
        public static void AddByIndex<T>(ref T[] array, int index, T value)
        {
            T[] newArray = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == index) newArray[i] = value;
                else newArray[i] = array[i];
            }

            array = newArray;
        }
        public static void AddToEnd<T>(ref T[] array, T value)
        {
            T[] newArray = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[array.Length] = value;

            array = newArray;
        }
        public static void AddToTop<T> (ref T[] array, T value)
        {
            T[] newArray = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            newArray[0] = value;

            array = newArray;
        }
        public static void Resize<T>(ref T[] array, int counter)
        {
            T[] newArray = new T[counter];

            for (int i = 0; i < newArray.Length && i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        public static void WriteArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

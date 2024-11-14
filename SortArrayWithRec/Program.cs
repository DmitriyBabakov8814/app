using System;

namespace SortArrayWithRec
{

    internal class Program
    {

        static int[] GetArrayFromConsole(int num = 10)
        {

            int[] result = new int[num];
            
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
            
        }

        static int[] SortArray(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[i])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Число элемента массива № {0} = {1}", i + 1, result[i]);
            }

            return result;
        }

        static void ShowArray(int[] array, bool sortar = false)
        {
            if (sortar)
            {
                SortArray(array);
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Число элемента массива № {0} = {1}", i + 1, array[i]);
                }
            }
            
        }


        static void Main(string[] args)
        {
            int[] array = GetArrayFromConsole();

            SortArray(array);

        }
    }

}

using System;

namespace SortArrayWithRec
{

    internal class Program
    {

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            for(int i =  0; i < result.Length; i++)
            {
                for(int j = i + 1; j < result.Length; j++)
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



        static void Main(string[] args)
        {
            GetArrayFromConsole();
        }
    }

}

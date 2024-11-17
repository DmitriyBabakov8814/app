namespace SortArrayDescAsc
{
    class Program
    {
        static int[] PullArray()
        {
            
            Console.WriteLine("Введите размерность массива");
            int lenarr = int.Parse(Console.ReadLine());
            int[] array = new int[lenarr];
            array = new int[lenarr];
            for (int i = 0; i < lenarr; i++)
            {
                Console.WriteLine("Введите элемент масива номер {0}", i+1);
                int data = int.Parse(Console.ReadLine());
                array[i] = data;
            }
            return array;

        }
        static void ShowArray(int[] array)
        {
            for (int i = 0;i < array.Length; i++)
            {
                Console.WriteLine("Элемент массива номер {0} = {1}", i + 1, array[i]);
            }
        }

        static int[] SortArrayAsc(int[] AscResult)
        {

            int data = 0;
            for (int i = 0; i < AscResult.Length; i++)
            {
                for(int j = i + 1; j < AscResult.Length; j++)
                {
                    data = AscResult[i];
                    if (AscResult[i] > AscResult[j])
                    {
                        data = AscResult[j];
                        AscResult[j] = AscResult[i];
                        AscResult[i] = data;
                    }
                }
            }

            Console.WriteLine("Отсортированные элементы массива по возрастанию");
            ShowArray(AscResult);

            return AscResult;
        }

        static int[] SortArrayDesc(int[] DescResult)
        {

            int data = 0;
            for (int i = 0; i < DescResult.Length; i++)
            {
                for (int j = i + 1; j < DescResult.Length; j++)
                {
                    data = DescResult[i];
                    if (DescResult[i] < DescResult[j])
                    {
                        data = DescResult[i];
                        DescResult[i] = DescResult[j];
                        DescResult[j] = data;
                    }
                }
            }

            Console.WriteLine("Отсортированные элементы массива по убыванию");
            ShowArray(DescResult);

            return DescResult;


        }

        static void SortArray(int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(array);
            sortedasc = SortArrayAsc(array);

           
        }


        static void Main(string[] args)
        {
            int[] array = PullArray();

            SortArray(array, out int[] sorteddesc, out int[] sortedasc);

            


        }
    }
}

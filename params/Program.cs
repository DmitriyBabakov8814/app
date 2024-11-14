namespace params
{
    class Program
{
    static void ShowColors(params string[] favcolors)
    {
        Console.WriteLine("Ваши любимые цвета:");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }
    }

    static void Main(string[] args)
    {
        string[] favcolors = new string[3] { "Красный", "Синий", "Зеленый" };

        // Вызываем метод с передачей отдельных значений, а не массива
        ShowColors(favcolors[0], favcolors[2]);
    }
}
}

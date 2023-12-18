internal class Program
{
    private static void Main(string[] args)
    {
        string path = "C:\\Users\\Пользователь\\Desktop\\24_demo.txt"; // Путь к файлу
        string str = File.ReadAllText(path); // Чтение содержимого файла и сохранение в переменную "str"

        int m = 1, k = 1; // Инициализация переменных m и k
        for (int i = 1; i < str.Length; i++) // Цикл для обхода символов в строке
        {
            if (str[i] != str[i - 1]) // Проверка, если текущий символ не равен предыдущему символу
                k++; // Увеличение значения k на 1
            else
            {
                m = Max(k, m); // Вызов метода Max для вычисления максимального значения между k и m
                k = 1; // Сброс значения k в 1
            }
        }
        Console.WriteLine(m); // Вывод значения m
        
        // Метод для вычисления максимального значения между двумя числами
        public static int Max(int a, int b)
        {
            return a > b ? a : b; // Возврат максимального значения между a и b
        }
    }
}

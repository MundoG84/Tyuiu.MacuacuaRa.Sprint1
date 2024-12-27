using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MacuacuaRa.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false; // Пустая строка не имеет повторения
            }

            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length < 2)
            {
                return false; // Одно слово не может содержать повторений
            }

            string lastWord = words[^1]; // Получаем последнее слово

            // Проверяем, что последнее слово не только последнее
            return words.Take(words.Length - 1).Any(word => word.Equals(lastWord, StringComparison.OrdinalIgnoreCase));
        }
    }
}

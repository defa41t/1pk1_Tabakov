namespace Task_21_10
{
    internal class Program
    {
        /*Написать метод, который объединяет два словаря. Если ключ присутствует в обоих словарях, суммировать их значения.*/
        static void Main(string[] args)
        {
            var dict1 = new Dictionary<string, int>
        {
            { "hello", 1 },
            { "world", 2 },
            { "peace", 3 }
        };

            var dict2 = new Dictionary<string, int>
        {
            { "hello", 3 },
            { "programming", 1 },
            { "peace", 4 }
        };

            var mergedDict = Dictionaries(dict1, dict2);

            foreach (var i in mergedDict)
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
        }

        static Dictionary<string, int> Dictionaries(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            var result = new Dictionary<string, int>(dict1);

            foreach (var i in dict2)
            {
                if (result.ContainsKey(i.Key))
                {
                    result[i.Key] += i.Value;
                }
                else
                {
                    result[i.Key] = i.Value; 
                }
            }

            return result;
        }
    }
}

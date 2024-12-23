namespace lb14
{
    using System;
    using System.Collections.Specialized;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = File.ReadAllText("C:\\Users\\artem\\OneDrive\\Рабочий стол\\ля.txt");
                int maxpairs = MaxPairs(text);
                Console.WriteLine("Максимальное количество пар: " + maxpairs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        static int MaxPairs(string text)
        {
            int maxCount = 0;
            int currentCount = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                string pair = text.Substring(i, 2);
                if (pair == "AB" || pair == "CB")
                {
                    currentCount++;
                    i++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 0;
                }

            }
            maxCount = Math.Max(maxCount, currentCount);
            return maxCount;
        }
    }
}

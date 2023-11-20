using System;
using System.Xml;

namespace ReferanseTypeVSverditype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            int totalCount = 0;

            string text = "something";

            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();

                foreach (var character in text ?? string.Empty)
                {
                    
                    var lowercaseChar = char.ToLower(character);

                    counts[(int)lowercaseChar]++;
                    totalCount++;
                }
            }

            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    double percentage = (double)counts[i] / totalCount * 100;
                    string result = $"{counts[i]} - {percentage:F2}%";
                    string charactersUsed = $"{character}";
                    Console.WriteLine(charactersUsed);
                    Console.CursorLeft = Console.BufferWidth - result.Length - 1;
                    Console.WriteLine(result);
                    
                }
            }
        }
    }
}
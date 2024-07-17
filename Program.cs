using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine();
        
        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            bool hasConsecutiveConsonants = HasConsecutiveConsonants(word);
            Console.WriteLine(hasConsecutiveConsonants);
        }
    }

    static bool HasConsecutiveConsonants(string word)
    {
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (!vowels.Contains(word[i]) && !vowels.Contains(word[i + 1]))
            {
                return true;
            }
        }

        return false;
    }
}


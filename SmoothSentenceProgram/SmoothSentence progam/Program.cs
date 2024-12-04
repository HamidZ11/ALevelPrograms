using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter setence: ");
        string inputSentence = Console.ReadLine();
        bool isSmooth = IsSmoothSentence(inputSentence);
        Console.WriteLine(isSmooth);
    }

    static bool IsSmoothSentence(string sentence)
    {
        // Split the sentence into words
        string[] words = sentence.Split(' ');

        // Check if there are at least two words in the sentence
        if (words.Length < 2)
        {
            return false;
        }

        // Loop through the words to check the smoothness
        for (int i = 0; i < words.Length - 1; i++)
        {
            string currentWord = words[i];
            string nextWord = words[i + 1];

            // Convert both words to lowercase for case insensitivity
            currentWord = currentWord.ToLower();
            nextWord = nextWord.ToLower();

            // Check if the last letter of the current word matches the first letter of the next word
            if (currentWord[currentWord.Length - 1] != nextWord[0])
            {
                return false;
            }
        }

        // If all checks pass, it's a smooth sentence
        return true;
    }
}


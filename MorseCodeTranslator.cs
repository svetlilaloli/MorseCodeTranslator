using System;

namespace MorseCodeTranslator
{
    class MorseCodeTranslator
    {
        static void Main(string[] args)
        {
            string[] morseWords = Console.ReadLine().Split('|');
            int length = morseWords.Length;
            string[] translatedWords = new string[length];

            for (int i = 0; i < length; i++)
            {
                string[] morseLetters = morseWords[i].Trim().Split();
                string word = "";

                for (int j = 0; j < morseLetters.Length; j++)
                {

                    switch (morseLetters[j])
                    {
                        case ".-": word += 'A'; break;
                        case "-...": word += 'B'; break;
                        case "-.-.": word += 'C'; break;
                        case "-..": word += 'D'; break;
                        case ".": word += 'E'; break;
                        case "..-.": word += 'F'; break;
                        case "--.": word += 'G'; break;
                        case "....": word += 'H'; break;
                        case "..": word += 'I'; break;
                        case ".---": word += 'J'; break;
                        case "-.-": word += 'K'; break;
                        case ".-..": word += 'L'; break;
                        case "--": word += 'M'; break;
                        case "-.": word += 'N'; break;
                        case "---": word += 'O'; break;
                        case ".--.": word += 'P'; break;
                        case "--.-": word += 'Q'; break;
                        case ".-.": word += 'R'; break;
                        case "...": word += 'S'; break;
                        case "-": word += 'T'; break;
                        case "..-": word += 'U'; break;
                        case "...-": word += 'V'; break;
                        case ".--": word += 'W'; break;
                        case "-..-": word += 'X'; break;
                        case "-.--": word += 'Y'; break;
                        case "--..": word += 'Z'; break;
                        default: break;
                    }
                }
                translatedWords[i] = word;
            }

            Console.WriteLine(String.Join(" ", translatedWords));
        }
    }
}

namespace ConsoleAppLearning1.Learning.Streams;

using System;
using System.IO;

    public class ByteToCharacter
    {
        public static void ConvertBytesToCharacters()
        {
            string filePath = "input.txt";

            try
            {
                using FileStream fs = new FileStream(
                    filePath,
                    FileMode.Open,
                    FileAccess.Read);

                using StreamReader reader = new StreamReader(fs);

                while (!reader.EndOfStream)
                {
                    Console.Write(reader.Read());
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
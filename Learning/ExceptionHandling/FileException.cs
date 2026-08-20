namespace ConsoleAppLearning1.Learning.ExceptionHandling;

public class FileException
{
    public void FileExceptionHandling()
    {
        try
        {
          using  FileStream fs = new FileStream(@"test1.txt", FileMode.Open);
          using  StreamReader streamReader = new StreamReader(fs);
          string? str;
            if (!File.Exists(@"test1.txt"))
            {
                throw new FileNotFoundException();
            }
            while ((str = streamReader.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }

           fs.Position = 0; 
            int s;
            while ((s = streamReader.Read()) != -1)
            {
                Console.WriteLine((char)s);
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File not found : {e.Message}");
        }
    }
}
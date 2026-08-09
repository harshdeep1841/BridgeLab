using System.Text.RegularExpressions;

namespace ConsoleAppLearning1.Learning.Operator.Learning.RegixExplore;

public class BasicRegex
{
    public void Basics1()
    {
        string str = "I am 22  years  old";
        string pattern = @"\d+"; 
        
        Match match = Regex.Match(str , pattern);
        if (match.Success)
        {
            Console.WriteLine(match.Value);
        }

        string str2 = "Hello Harsh";
        string pattern2 = "Har";
        Match match2 = Regex.Match(str2, pattern2);
        if (match2.Success)
        {
            Console.WriteLine(match2.Value);
        }

        string str3 = "Hello_123!";
        string pattern3 = @"\w+";
        Match match3 = Regex.Match(str3, pattern3);
        if (match3.Success)
        {
            Console.WriteLine(match3.Value);
        }

        string str4 = "This is a string";
        string pattern4 = @"\s+";
        string pattern5 = @"\S+";
        string pattern6 = @"n..";
        Match match4 = Regex.Match(str4 , pattern4);
        Match match5 = Regex.Match(str4, pattern5);
        Match match6 = Regex.Match(str4, pattern6);
        // if (match4.Success)
        // {
        //     Console.WriteLine(match4.Value);
        // }

        if (match5.Success)
        {
            Console.WriteLine(match5.Value);
        }

        if (match6.Success)
        {
            Console.WriteLine(match6.Value);
        }
        
        string str7 = "catagory cat";
        string pattern7 = @"\cat\b"; //find for seprate cat word
        Match match7 = Regex.Match(str7, pattern7);
        if (match7.Success)
        {
            Console.WriteLine(match7.Value);
        }

        string str8 = "Harsh";
        string pattern8 = @"[A-Z][a-z]+";
        Match match8 = Regex.Match(str8, pattern8);

        if (match8.Success)
        {
            Console.WriteLine(match8.Value);
        }
        string str9 = "abab";
        string pattern9 = @"bc*"; //here b must occur but c can be >=0 times
        Match match9 = Regex.Match(str9, pattern9);
        if (match9.Success)
        {
            Console.WriteLine(match9.Value);
        }
        string str10 = "colour";
        string pattern10 = @"colou?r";
        Match match10 = Regex.Match(str10, pattern10);
        if (match10.Success)
        {
            Console.WriteLine(match10.Value);
        }
        
        string str11 = "My PIN is 123";
        string str12 = "a a";
        //string pattern11 = @"\d{2}";
        string pattern12 = @"\d{2,}";
        string pattern13 = @"\d{2,2}";
        string pattern14 = @"a{2,5}";
        Match match11 = Regex.Match(str12, pattern14);

        if (match11.Success)
        {
            Console.WriteLine(match11.Value);
        }
       

    }
}

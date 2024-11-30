namespace Exam;

public class Program
{
    static void Main(string[] args)
    {


    }

    public static bool StartsWithPdp(string text)
    {
        if (text.StartsWith("PDP"))
        {
            return true;
        }
        return false;
    }

    public static string GetStartThree(string text)
    {
        if (text.Length < 3)
        {
            return text;
        }
        return text.Substring(0, 3);
    }

    public static List<int> GetFilledList(int length)
    {
        var digits = new List<int>();
        for (int i = 0; i < length; i++)
        {
            Console.Write($"{i} : ");
            var numbers = int.Parse(Console.ReadLine());
            digits.Add(length);

        }
        return digits;

    }
    public static int GetEvenElements(List<int> list)
    {
        var counter = 0;
        foreach (var element in list)
        {
            if (element % 2 == 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public static bool GetEvenElements(List<string> text)
    {
        foreach (var element in text)
        {
            if (element.Length > 5)
            {
                return true;
            }
        }

        return false;
    }
}

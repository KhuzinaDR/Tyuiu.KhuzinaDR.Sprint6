using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhuzinaDR.Sprint6.Task6.V12.Lib;

public class DataService : ISprint6Task6V12
{

    public string CollectTextFromFile(string path)
    {
        string res = "";
        string[] text = File.ReadAllText(path).Replace("\n", " ").Split(" ");

        foreach (string s in text)
        {
            if (s.Contains('w'))
                res += s + " ";
        }

        return res.Substring(0, res.Length - 1);
    }

    public string CollectTextFromFile(string str, string path)
    {
        throw new NotImplementedException();
    }
}
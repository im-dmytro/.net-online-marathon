
using System.Linq;

class MyUtils
{
    public static bool ListDictionaryCompare(List<string> strings,
        Dictionary<string, string> pairs)
    {
        if (strings.Count == 0 || pairs.Count == 0) return false;

        var distinctList = strings.DistinctBy(x => x.Trim()).ToList();
        var distinctPairsList = pairs.Values.DistinctBy(x => x.Trim()).ToList();
        if (distinctList.Count < pairs.Count) return false;
        foreach (var item in distinctPairsList)
        {
            if (!strings.Contains(item)) { return false; }
        }
        return true;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        MyUtils.ListDictionaryCompare(new List<string> { "cc", "bb", "gg", "aa", "cc", "aa" },
            new Dictionary<string, string> { { "1", "bb" }, { "2", "cc" }, { "3", "aa" }, { "4", "cc" } });
    }
}

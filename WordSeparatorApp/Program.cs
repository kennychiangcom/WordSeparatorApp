using System.Linq;
namespace WordSeparatorApp
{
    
    public class Program
    {
        public static void Main()
        {
            var x = Program.CompoundStrings("aet brq cxg hop eas fwr wms");
            Console.WriteLine(string.Join(" ",x));
        }

        public static string[] CompoundStrings(string cpndstr)
        {
            string[] assortedwords = cpndstr.Split();
            string[] sortedwords = assortedwords.OrderBy(x => x[x.Length-1]).ToArray();
            return sortedwords; 
        }
    }
}
using System.Runtime.CompilerServices;

namespace TohmeConsole
{
    internal static class Extentios
    {

        public static void WriteList<T>(this List<T> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item?.ToString());
            }
        }
    }
}

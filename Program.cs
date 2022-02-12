using System;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            var map = new QHashMap<int, string>(10);
            var result = string.Empty;
            map.Insert(1, "Emre");
            map.Insert(2, "Ali");
            map.Insert(3, "Veli");
            result = map.ReadAll();
            System.Console.WriteLine(result);
            map.Remove(3);
            result = map.ReadAll();
            System.Console.WriteLine(result);
            map.Update(1, "Emre Kılıç");
            result = map.ReadAll();
            System.Console.WriteLine(result);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary_ja_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<int, string>
            {
                {1, "Tööstushariduskeskus" },
                {2, "Tallinna Polütehnikum" },
                {3, "Tallinna 21.Kool" },
            };

            result.ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Value}"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> map = new Dictionary<string, string>
            {
            { "a", "candy" },
            { "b", "dirt" }
            };
            map = mapBully(map);
            foreach (KeyValuePair<string, string> x in map)
            {
                Console.WriteLine($"Key = {x.Key}, Value = {x.Value}");
            }
            Console.ReadLine();
        }
        public static Dictionary<string, string> mapBully(Dictionary<string, string> map)
        {
            if (map.ContainsKey("a"))
            {
                map["b"] = map["a"];
                map["a"] = "";
                //map.put("b", map.get("a"));
                //map.put("a", "");
            }
            return map;
        }
    }
}

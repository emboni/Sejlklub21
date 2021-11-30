using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Helpers
{
    public class JsonFileWritter
    {
        public static void WriteToJsonBoat(List<IBoat> @events, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(@events, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }

        public static void WriteToJsonBlog(List<Blog> @events, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(@events, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}

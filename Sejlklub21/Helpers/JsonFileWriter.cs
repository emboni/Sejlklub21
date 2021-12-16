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
    public class JsonFileWriter
    {
        public static void WriteToJsonBoat(List<IBoat> boats, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(boats, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }

        public static void WriteToJsonEvent(List<Event> @events, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(@events, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }

        public static void WriteToJsonBlog(List<IBlogPost> @events, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(@events, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }

        public static void WriteJsonMembers(List<IMember> member, string jsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(member, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jsonFileName, output);
        }

        public static void WriteToJsonBooking(List<IBooking> bookings, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(bookings, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}

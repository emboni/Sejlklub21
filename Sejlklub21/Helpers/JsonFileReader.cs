﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Helpers
{
    public class JsonFileReader
    {
        public static List<Boat> ReadJsonBoats(string jsonFileName)
        {
            string jsonString = File.ReadAllText(jsonFileName);
            return JsonSerializer.Deserialize<List<Boat>>(jsonString);
        }

        public static List<Event> ReadJsonEvent(string jsonFileName)
        {
            string jsonString = File.ReadAllText(jsonFileName);
            return JsonSerializer.Deserialize<List<Event>>(jsonString);
        }

        public static List<Blog> ReadJsonBlog(string jsonFileName)
        {
            string jsonString = File.ReadAllText(jsonFileName);
            return JsonSerializer.Deserialize<List<Blog>>(jsonString);
        }

        public static List<IMember> ReadJsonMembers(string jsonFileName)
        {
            string jsonString = File.ReadAllText(jsonFileName);
            return JsonSerializer.Deserialize<List<Member>>(jsonString).ToList<IMember>();
        }
    }
}
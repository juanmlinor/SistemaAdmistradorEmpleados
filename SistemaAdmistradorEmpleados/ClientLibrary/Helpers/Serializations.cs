﻿using System.ComponentModel;
using System.Text.Json;

namespace ClientLibrary.Helpers
{
    public static class Serializations
    {
        public static string SerializeObj<T>(T modelObject) => JsonSerializer.Serialize(modelObject);
        public static T DeseriallizeJsonString<T>(string jsonString) => JsonSerializer.Deserialize<T>(jsonString);

        public static IList<T> DeseriallizeJsonStringList<T>(string jsonString) => JsonSerializer.Deserialize<IList<T>>(jsonString);

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DemoAPIDomain.Models
{
    public class ToDo
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("isComplete")]
        public bool Completed { get; set; }
    }
}

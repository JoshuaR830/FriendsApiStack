﻿using System.Text.Json.Serialization;

namespace BotuaGetFriendTimes.Models
{
    public class Champion
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("color")]
        public string Color { get; set; }
        
        [JsonPropertyName("timeActive")]
        public double TimeActive { get; set; }

        public Champion(string name, string color, double timeActive)
        {
            Name = name;
            Color = color;
            TimeActive = timeActive;
        }
    }
}
﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogApi.Models
{
    public class BySubBreed
    {
        [JsonProperty("message")]
        public string[] Message { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }

    }
}

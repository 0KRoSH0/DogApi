using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogApi.Model
{
    public class ResponseApi<T>
    {
            [JsonProperty("message")]
            public T Message { get; set; }
            [JsonProperty("status")]
            public string Status { get; set; }

    }

}
